using AspNetApp.Db;
using AspNetApp.Models.Infra;
using AspNetApp.Models.XmlModel;
using AspNetApp.Tools.Converters;
using AspNetApp.Tools.Helpers;
using System.Text;
using MongoDB.Bson;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace AspNetApp.Controllers
{
	public class TestController : Controller
	{
		private MongoDbProvider dbProvider;

		[HttpGet]
		public ViewResult Index()
		{
			return View();
		}

		[HttpGet]
		public ViewResult TestSelector()
		{
			return View();
		}

		[HttpPost]
		public ViewResult TestSelector(HttpPostedFileBase testFile)
		{
			if (testFile != null)
			{				
				var test = XmlConverter.Deserialize<Test>(testFile);
				var sorted = TestHelper.SortQuestionsByNumber(test);
				return View("Test", sorted);
			}
			else
				return null;
		}

		[HttpGet]
		public ViewResult TestEditor()
		{
			return View();
		}

		[HttpPost]
		public ViewResult TestEditor(string[] dynamicField)
		{
			ViewBag.Data = string.Join(",", dynamicField ?? new string[] { });
			return View();
		}

		[HttpPost]
		public ViewResult TestCheck(TestSorted test)
		{
			var json = new JavaScriptSerializer().Serialize(test);
			dbProvider = new MongoDbProvider("mongodb://localhost:27017");
			dbProvider.SetDatabase("effectivedb");
			dbProvider.SetCurrentCollection("test_results");

			var doc = test.ToBsonDocument();
			dbProvider.InsertOne(doc);
			return null;
		}
	}
}