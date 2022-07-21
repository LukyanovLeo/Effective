using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspNetApp.Db
{
	public class UserDbProvider
	{
		private SqlConnection conn { get; set; }

		public UserDbProvider(string connectionString)
		{
			conn = new SqlConnection(connectionString);
		}

		public void InsertNewUser(string login, string password, bool isAdmin)
		{
			var d = new DynamicParameters();
			d.Add("@login", login);
			d.Add("@password", password);
			d.Add("@reg_date", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
			d.Add("@is_admin", isAdmin);
			string query = @"INSERT INTO dbo.users (id, login, password, reg_date, last_login_date, is_admin)
											 VALUES (newid(), @login, @password, @reg_date, null, @is_admin)";
			conn.Execute(query, d);
		}
	}
}