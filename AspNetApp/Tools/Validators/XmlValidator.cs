using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using AspNetApp.Models.XmlModel;
using System.IO;

namespace AspNetApp.Tools.Validators
{
	public class XmlValidator
	{
		public void Validate()
		{
			var validator = new XmlReaderSettings();
			validator.Schemas.Add("candidate-test", @"E:\VS2017\Projects\Effective\AspNetApp\Models\Schemas\TestSchema.xsd");
			validator.ValidationType = ValidationType.Schema;
			var reader = XmlReader.Create(@"E:\VS2017\Projects\Effective\AspNetApp\Models\Xml\test.xml", validator);

			XmlDocument document = new XmlDocument();
			document.Load(reader);
			//document.Validate(testStructureValidationEventHandler);
		}

		private static void testStructureValidationEventHandler(object sender, ValidationEventArgs e)
		{
			if (e.Severity == XmlSeverityType.Warning)
			{
				Console.Write("WARNING: ");
				Console.WriteLine(e.Message);
			}
			else if (e.Severity == XmlSeverityType.Error)
			{
				Console.Write("ERROR: ");
				Console.WriteLine(e.Message);
			}
		}
	}
}