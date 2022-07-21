using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace AspNetApp.Models
{
	public class Offence
	{
		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("code")]
		public string Code { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("paragraph")]
		public string Paragraph { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("status")]
		public string Status { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("registrationDate")]
		public string RegistrationDate { get; set; }
	}
}