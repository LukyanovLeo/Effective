using AspNetApp.Models.XmlModel;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace AspNetApp.Tools.Converters
{
	public class XmlConverter
	{
		public static T Deserialize<T>(string path) where T : class
		{
			var validator = new XmlReaderSettings();
			validator.Schemas.Add("candidate-test", @"E:\VS2017\Projects\Effective\AspNetApp\Models\Schemas\TestSchema.xsd");
			validator.ValidationType = ValidationType.Schema;

			var reader = XmlReader.Create(path, validator);
			XmlDocument document = new XmlDocument();
			document.Load(reader);

			var serializer = new XmlSerializer(typeof(Test));
			var stringReader = new StringReader(document.InnerXml);
			return (T)serializer.Deserialize(stringReader);
		}

		public static T Deserialize<T>(HttpPostedFileBase testFile) where T : class
		{
			var buffer = new byte[testFile.ContentLength];
			testFile.InputStream.Read(buffer, 0, testFile.ContentLength);
			var content = Encoding.UTF8.GetString(buffer);
			content = content.Replace("\r\n", "").Replace("\t", "").Replace("\\", "");

			var document = new XmlDocument();
			document.LoadXml(content);

			var serializer = new XmlSerializer(typeof(Test));
			var stringReader = new StringReader(document.InnerXml);
			return (T)serializer.Deserialize(stringReader);
		}
	}
}