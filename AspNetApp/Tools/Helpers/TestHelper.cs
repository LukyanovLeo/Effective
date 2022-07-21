using AspNetApp.Models.Infra;
using AspNetApp.Models.XmlModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetApp.Tools.Helpers
{
	public class TestHelper
	{
		public static TestSorted SortQuestionsByNumber(Test test)
		{
			var testSorted = new TestSorted();
			testSorted.Name = test.Name;
			testSorted.Time = test.Time;
			testSorted.AttemptNumber = test.AttemptNumber;
			testSorted.Questions = 
							(test.Questions.SingleAnswers?.SingleAnswers?.Cast<BaseAnswer>() ?? Enumerable.Empty<BaseAnswer>())
								.Union(test.Questions.MultipleAnswers?.MultipleAnswers?.Cast<BaseAnswer>() ?? Enumerable.Empty<BaseAnswer>())
								.Union(test.Questions.InputAnswers?.InputAnswers?.Cast<BaseAnswer>() ?? Enumerable.Empty<BaseAnswer>())
								.Union(test.Questions.FreeAnswers?.FreeAnswers?.Cast<BaseAnswer>() ?? Enumerable.Empty<BaseAnswer>())
								.OrderBy(q => q.Number).ToList();
			return testSorted;
		}
	}
}