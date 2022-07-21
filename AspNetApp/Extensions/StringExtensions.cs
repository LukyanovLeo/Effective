using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace AspNetApp.Extensions
{
	static class StringExtensions
	{
		public static IEnumerable<string> SplitToWords(this string text)
		{
			var regex = new Regex("[а-яА-Я-]+");
			var matches = regex.Matches(text);

			foreach (Match match in matches)
				yield return match.Value;
		}
	}
}