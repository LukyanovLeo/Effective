using AspNetApp.Extensions;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace AspNetApp.Tools
{
	public class TextTools
	{
		public static IEnumerable<string> FuzzySearch(string text, IEnumerable<string> patterns)
		{
			var words = text.SplitToWords();

			foreach (var pattern in patterns)
				foreach (var word in words)
					if (LevenshteinDistance(word.ToLower(), pattern) <= 3)
						yield return word;
		}

		public static IEnumerable<string> FuzzySearchPhrase(string text, IEnumerable<string> matchedWords, IEnumerable<string> patterns)
		{
			var words = text.SplitToWords().ToList();

			foreach (var matchedWord in matchedWords)
				if (words.Contains(matchedWord))
				{
					int index = words.ToList().FindIndex(w => w == matchedWord);

					for (int i = 1; i <= 3; i++)
					{
						//bool breaker = false;
						if (index + i < words.Count())
						{
							foreach (var pattern in patterns)
								if (LevenshteinDistance(words[index + i].ToLower(), pattern) <= 3)
								{
									yield return words[index + i];
									break;
								}
						}
						if (index - i >= 0)
						{
							foreach (var pattern in patterns)
								if (LevenshteinDistance(words[index - i].ToLower(), pattern) <= 3)
								{
									yield return words[index - i];
									break;
								}
						}
					}
				}
		}

		public static int LevenshteinDistance(string string1, string string2)
		{
			if (string1 == null)
				return 0;
			if (string2 == null)
				return 0;

			int diff;
			int[,] m = new int[string1.Length + 1, string2.Length + 1];

			for (int i = 0; i <= string1.Length; i++)
				m[i, 0] = i;
			for (int j = 0; j <= string2.Length; j++)
				m[0, j] = j;

			for (int i = 1; i <= string1.Length; i++)
			{
				for (int j = 1; j <= string2.Length; j++)
				{
					diff = (string1[i - 1] == string2[j - 1]) ? 0 : 1;
					m[i, j] = Math.Min(Math.Min(m[i - 1, j] + 1,
																	 m[i, j - 1] + 1),
																	 m[i - 1, j - 1] + diff);
				}
			}
			return m[string1.Length, string2.Length];
		}
	}
}