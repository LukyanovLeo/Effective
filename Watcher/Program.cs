using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Watcher.Db;

namespace Watcher
{
	static class Program
	{
		static void Main()
		{
			//var prov = new SQLiteDataAdapter();

			var provider = new SQLiteProvider(@"Data Source=E:\History");
			var cmd = provider.MakeCommand("select title from urls");
			provider.Execute(cmd);
		}
	}
}
