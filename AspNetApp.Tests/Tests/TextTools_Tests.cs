using System;
using NUnit.Framework;
using AspNetApp.Tools;
using DataGrabber.TextAnalyser;
using AspNetApp.Tests.TestData;
using System.Collections;
using System.Collections.Generic;

namespace AspNetApp.Tests
{
	[TestFixture]
	class TextTools_Tests : TextTools_TestData
	{
		[Test]
		[TestCaseSource(sourceName: nameof(FuzzySearchTexts), sourceType: typeof(TextTools_TestData))]
		public void FuzzySearch_Test(string text, IEnumerable<string> patterns, List<string> expected)
		{
			var actual = TextTools.FuzzySearch(text, patterns);
			CollectionAssert.AreEqual(expected, actual, "Wrong output");
		}

		[Test]
		[TestCaseSource(sourceName: nameof(FuzzySearchTextsPhrase), sourceType: typeof(TextTools_TestData))]
		public void FuzzySearchPhrase_Test(string text, IEnumerable<string> matchedWords, IEnumerable<string> patterns, List<string> expected)
		{
			var actual = TextTools.FuzzySearchPhrase(text, matchedWords, patterns);
			CollectionAssert.AreEqual(expected, actual, "Wrong output");
		}
	}
}
