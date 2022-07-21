using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApp.Tests.TestData
{
	class TextTools_TestData
	{
		protected static IEnumerable<object[]> FuzzySearchTexts()
		{
			yield return new object[]
			{
				"Дорогие друзья, постоянный количественный рост и сфера нашей активности требует от нас анализа соответствующих условий активизации",

				new List<string>
				{
					"рост",
					"сферы"
				},

				new List<string>
				{
					"рост",
					"сфера"
				},
			};
		}

		protected static IEnumerable<object[]> FuzzySearchTextsPhrase()
		{
			yield return new object[]
			{
				"Дорогие друзья, постоянный количественный рост и сфера нашей активности требует от нас анализа соответствующих условий активизации",

				new List<string>
				{
					"количественный",
				},

				new List<string>
				{
					"рост",
					"сферы",
					"активность",
				},

				new List<string>
				{
					"рост",
					"сфера",
				},
			};
		}
	}
}
