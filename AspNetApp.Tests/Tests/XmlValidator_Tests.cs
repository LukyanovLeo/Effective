using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetApp.Tools.Validators;
using NUnit.Framework;

namespace AspNetApp.Tests.Tests
{
	[TestFixture]
	class XmlValidator_Tests
	{
		private XmlValidator validator;

		[SetUp]
		public void Init()
		{
			validator = new XmlValidator();
		}

		[Test]
		public void ValidateValidXml_Test()
		{
			validator.Validate();
		}
	}
}
