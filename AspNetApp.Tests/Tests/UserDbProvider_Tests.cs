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
	class UserDbProvider_Tests
	{
		//private UserDbProvider provider;

		[SetUp]
		public void Init()
		{
			//provider = new UserDbProvider(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\VS2017\Projects\Effective\AspNetApp\App_Data\UserDb.mdf;Integrated Security=True");
		}

		[Test]
		public void InsertUser_Valid_Test()
		{
			//provider.InsertNewUser("lalka", "sasai", true);
		}
	}
}
