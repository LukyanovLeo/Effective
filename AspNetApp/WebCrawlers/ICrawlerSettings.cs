using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApp.WebCrawlers
{
	interface ICrawlerSettings
	{
		string BaseUrl { get; set; }

		List<string> RegexSet { get; set; }
	}
}
