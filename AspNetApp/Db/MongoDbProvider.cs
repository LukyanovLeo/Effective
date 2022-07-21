using AspNetApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using NLog;

namespace AspNetApp.Db
{
	public class MongoDbProvider
	{
		private Logger logger = LogManager.GetCurrentClassLogger();

		public MongoClient Client { get; private set; }
		public IMongoDatabase DbCurrent { get; private set; }
		public IMongoCollection<BsonDocument> CollectionCurrent { get; private set; }


		public MongoDbProvider(string connectionString)
		{
			Client = new MongoClient(connectionString);
			logger.Info($"Mongo client created. Connection string is {connectionString}");
		}

		public void SetDatabase(string dbName)
		{
			try
			{
				logger.Info($"Client {Client} requested DB with name '{dbName}'");
				if (GetAllDbNames().Contains(dbName.ToLower()))
				{
					DbCurrent = Client.GetDatabase(dbName);
					logger.Info($"Successfull request for DB '{dbName}'");
				}
				else
				{
					throw new KeyNotFoundException();
				}
			}
			catch (KeyNotFoundException ex)
			{
				logger.Error($"There is no DB with name '{dbName}' on server {Client}");
			}
		}
		
		public void SetCurrentCollection(string collectionName)
		{
			try
			{
				if (GetAllCollectionNamesInDb().Contains(collectionName.ToLower()))
					CollectionCurrent = DbCurrent.GetCollection<BsonDocument>(collectionName);
				else
					throw new KeyNotFoundException();
			}
			catch (KeyNotFoundException ex)
			{

			}
		}

		public void InsertOne(BsonDocument bDoc)
		{
			try
			{
				CollectionCurrent.InsertOne(bDoc);
			}
			catch (NullReferenceException ex)
			{

			}
			catch (Exception ex)
			{

			}
		}

		public async Task<List<BsonDocument>> FindAllDocs()
		{
			var list = new List<BsonDocument>();
			var filter = new BsonDocument();
			try
			{
				using (var cursor = await CollectionCurrent.FindAsync(filter))
				{
					while (await cursor.MoveNextAsync())
					{
						var people = cursor.Current;
						list.AddRange(people);
					}
				}
			}
			catch (Exception ex)
			{

			}
			return list;
		}

		public List<BsonDocument> FindDocs(BsonDocument filter)
		{
			var list = new List<BsonDocument>();
			try
			{
				var results = CollectionCurrent.Find(filter).ToList();
				list.AddRange(results);
			}
			catch (Exception ex)
			{

			}
			return list;
		}


		private IEnumerable<string> GetAllDbNames()
		{
			try
			{
				return Client.ListDatabases().ToList().Select(e => e["name"].ToString());
			}
			catch (Exception ex)
			{
				//TODO: add logs
				return null;
			}
		}

		private IEnumerable<string> GetAllCollectionNamesInDb()
		{
			try
			{
				return DbCurrent.ListCollections().ToList().Select(e => e["name"].ToString());
			}
			catch (Exception ex)
			{
				//TODO: add logs
				return null;
			}
		}
	}




	public class MongoDbEngine
	{
		public static void MongoRun(Candidate user)
		{
			// подключение к серверу MongoDb
			string conn = "mongodb://localhost:27017";//ConfigurationManager.ConnectionStrings["Mongo"].ConnectionString;
			var client = new MongoClient(conn);

			// получение всех БД на сервере
			var db = client.GetDatabase("effectivedb");

			// получение всех коллекций выбранной БД 
			// (в БД несколько коллекций, в коллекции несколько документов в формате BSON)
			// вместо User может быть BsonDocument
			var collection = db.GetCollection<BsonDocument>("candidates");

			// делаем BSON из си-шарп-объекта

			var doc = user.ToBsonDocument();

			// добавляем документ в БД
			// вместо user может быть doc
			collection.InsertOne(doc);

			// ищем документы в БД
			// FindDocs().GetAwaiter().GetResult();

			//GetCollectionsNames(client).GetAwaiter();
			Console.ReadLine();

			// фильтрация данных
			var filter1 = new BsonDocument("$or", new BsonArray
			{
					new BsonDocument("Age",new BsonDocument("$gte", 33)),
					new BsonDocument("Name", "Tom")
			});
			var builder = Builders<BsonDocument>.Filter;
			var filter2 = builder.Eq("Name", "Bill") & !builder.Eq("Age", 30);
		}
	}
}