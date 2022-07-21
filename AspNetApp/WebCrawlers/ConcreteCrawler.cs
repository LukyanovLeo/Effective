using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AspNetApp.Model;

namespace AspNetApp.WebCrawlers
{
	class HhCrawler : ICrawler<ConcreteSite>, ICrawlerSettings
	{
		public string Name { get; set; }
		public string UserAgent { get; set; }
		public string BaseUrl { get; set; }
		public List<string> RegexSet { get; set; }

		public HhCrawler()
		{
			Name = "hh.crawler";
			UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";
			BaseUrl = "https://hh.ru/employer";
			RegexSet = new List<string>()
			{
				"span data-qa=\"resume-serp__resume-age\">(?<age>.*)</span>",
			};
		}	

		public IEnumerable<ConcreteSite> Run()
		{
			var request = WebRequest.Create("https://hh.ru/search/resume?area=1&clusters=true&exp_period=all_time&logic=normal&pos=full_text&from=employer_index_header&text=%D1%82%D0%BE%D0%BA%D0%B0%D1%80%D1%8C");
			using (var response = request.GetResponse())
			{
				using (Stream stream = response.GetResponseStream())
				{
					using (StreamReader reader = new StreamReader(stream))
					{
						var regex = new Regex(String.Join("(.|\\s)*", RegexSet));
						string text = reader.ReadToEnd();
						var matches = regex.Matches(text);

						foreach (Match match in matches)
						{
							var a = match;
						}
					}
				}
			}
			return null;
		}

		public void Stop()
		{
			
		}
	}
}
