using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using System.Web.Mvc;
using AspNetApp.Db;
using MongoDB.Bson.Serialization;
using AspNetApp.Models;
using System.Net;
using System.Net.Sockets;
using System.Text;
using AspNetApp.Tools.Helpers;

namespace AspNetApp.Controllers
{
  public class CandidateController : Controller
  {
		private MongoDbProvider dbProvider;

		public ActionResult Index()
    {
			ViewBag.Greetings = "Hi from Candidate View!";
      return View();
    }

		[HttpGet]
		public EmptyResult Generated()
		{
			return new EmptyResult();
		}

		[HttpGet]
		public ViewResult Efficiency()
		{
			dbProvider = new MongoDbProvider("mongodb://localhost:27017");
			dbProvider.SetDatabase("effectivedb");
			dbProvider.SetCurrentCollection("candidates");
			var allCandidatesBson = dbProvider.FindDocs(new BsonDocument());
			var ids = new List<string>();
			foreach (var candidateBson in allCandidatesBson)
			{
				var id = candidateBson.Where(d => d.Name == "_id").Select(d => d.Value).First().ToString();
				ids.Add(id);
			}
			ViewBag.Ids = ids;
			//var allCandidates = new List<Candidate>();
			//foreach (var candidateBson in allCandidatesBson)
			//{
			//	allCandidates.Add(BsonSerializer.Deserialize<Candidate>(candidateBson));
			//}
			return View();
		}

		[HttpPost]
		public ViewResult GetEvaluation(string id)
		{
			int port = 9090; // порт сервера
			string address = "127.0.0.1"; // адрес сервера
			var text = new StringBuilder();
			try
			{
				var ipPoint = new IPEndPoint(IPAddress.Parse(address), port);

				var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				socket.Connect(ipPoint);
				byte[] data = Encoding.Unicode.GetBytes(id);
				socket.Send(data);

				// получаем ответ
				data = new byte[256]; // буфер для ответа
				int bytes = 0; // количество полученных байт

				do
				{
					bytes = socket.Receive(data, data.Length, 0);
					text.Append(Encoding.UTF8.GetString(data, 0, bytes));
				}
				while (socket.Available > 0);
				socket.Shutdown(SocketShutdown.Both);
				socket.Close();
			}
			catch (Exception ex)
			{
				
			}
			var eval = EvaluationHelper.ParseEvaluation(text.ToString());
			return View("GetEvaluation", eval);
		}
	}
}