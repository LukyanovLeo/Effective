using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace AspNetApp.Models
{
	public class Course
	{
		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("name")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("certificate")]
		public float? Score { get; set; }
	}
}