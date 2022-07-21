using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher.Db
{
	class SQLiteProvider
	{
		private SQLiteConnection conn { get; set; }

		public SQLiteProvider(string connectionString)
		{
			conn = new SQLiteConnection(connectionString);
			conn.Open();
		}

		public SQLiteCommand MakeCommand(string query)
		{
			SQLiteCommand cmd = new SQLiteCommand();
			cmd.Connection = conn;
			cmd.CommandText = query;
			return cmd;
		}

		public void Execute(SQLiteCommand cmd)
		{
			using (SQLiteDataReader dr = cmd.ExecuteReader())
			{
				using (var sw = new StreamWriter(@"E:\new.txt"))
				{
					while (dr.Read())
					{
						sw.WriteLine(dr["title"]);
					}
				}				
			}			
		}
	}
}
