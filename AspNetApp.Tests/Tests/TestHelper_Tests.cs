using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetApp.Models.XmlModel;
using AspNetApp.Tools.Converters;
using AspNetApp.Tools.Helpers;
using NUnit.Framework;

namespace AspNetApp.Tests.Tests
{
	[TestFixture]
	class TestHelper_Tests
	{
		[Test]
		[TestCase(@"E:\VS2017\Projects\Effective\AspNetApp\Models\Xml\test.xml")]
		public void Sort_Tests(string path)
		{
			var test = XmlConverter.Deserialize<Test>(path);
			var sorted = TestHelper.SortQuestionsByNumber(test);			
		}
	}
}
