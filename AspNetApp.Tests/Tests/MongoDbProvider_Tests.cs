using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetApp.Db;
using NUnit.Framework;

namespace AspNetApp.Tests.Tests
{
	[TestFixture]
	class MongoDbProvider_Tests
	{
		private MongoDbProvider mongoDbProvider;

		[SetUp]
		public void Init()
		{
			mongoDbProvider = new MongoDbProvider("mongodb://localhost:27017");
		}

		[Test]
		[TestCase("admin")]
		[TestCase("local")]
		[TestCase("config")]
		[TestCase("effectivedb")]
		public void GetExistingDataBase_Test(string dbName)
		{
			mongoDbProvider.SetDatabase(dbName);
			Assert.IsNotNull(mongoDbProvider.DbCurrent);
		}

		[Test]
		[TestCase("candidates")]
		[TestCase("new")]
		[TestCase("sdfkhdskjfh")]
		public void GetExistingCollection_Test(string collectionName)
		{
			mongoDbProvider.SetDatabase("effectivedb");
			Assert.DoesNotThrow(() => mongoDbProvider.SetCurrentCollection(collectionName));
		}
	}
}
