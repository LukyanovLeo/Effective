using AspNetApp.Db;
using AspNetApp.Models;
using AspNetApp.Models.Infra;
using MongoDB.Bson;
using NLog;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Web.Mvc;

namespace AspNetApp.Controllers
{
	public class HomeController : Controller
	{
		private MongoDbProvider dbProvider { get; set; }
		private Logger logger = LogManager.GetCurrentClassLogger();


		public ViewResult Index()
		{
			logger.Info("App started");
			//var cookie = new HttpCookie("My localhost cookie");
			//cookie.Values.Add("userid", "sveta");
			//cookie.Expires = DateTime.Now.AddDays(3);
			//Response.Cookies.Add(cookie);
			//ViewBag.Cookie = cookie.Values["userid"];

			return View();
		}

		[HttpPost]
		public ViewResult Index(User user)
		{
			dbProvider = new MongoDbProvider("mongodb://localhost:27017");
			dbProvider.SetDatabase("effectivedb");
			dbProvider.SetCurrentCollection("users");

			var filter = user.ToBsonDocument();
			var answ = dbProvider.FindDocs(filter);

			if (answ.Count > 0)
				return View("Hello");
			else
				return View("Index");
		}

		[HttpGet]
		public ViewResult AddCandidateForm()
		{
			logger.Info("Test form opened");
			return View();
		}

		[HttpGet]
		public ViewResult Rand()
		{
			return View();
		}

		[HttpGet]
		public ViewResult Efficiency()
		{
			return View();
		}

		[HttpPost]
		public ViewResult AddCandidateForm(Candidate candidate)
		{
			dbProvider = new MongoDbProvider("mongodb://localhost:27017");
			dbProvider.SetDatabase("effectivedb");
			dbProvider.SetCurrentCollection("candidates");

			var doc = candidate.ToBsonDocument();
			dbProvider.InsertOne(doc);

			return View("Thanks", candidate);
		}

		[HttpGet]
		public ViewResult AddNewUser()
		{
			return View();
		}

		[HttpPost]
		public ViewResult AddNewUser(User user)
		{
			dbProvider = new MongoDbProvider("mongodb://localhost:27017");
			dbProvider.SetDatabase("effectivedb");
			dbProvider.SetCurrentCollection("users");

			var doc = user.ToBsonDocument();
			dbProvider.InsertOne(doc);
			return View("Success");
		}
	}
}