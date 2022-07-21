using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApp.WebCrawlers
{
	interface ICrawler<T> where T : class
	{
		string Name { get; set; }

		string UserAgent { get; set; }

		IEnumerable<T> Run();

		void Stop();
	}
}
