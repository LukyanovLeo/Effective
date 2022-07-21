using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace AspNetApp.Models
{
	public class DriverLicence
	{
		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("number")]
		public string Number { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("categories")]
		public Category[] Categories { get; set; }
	}
}