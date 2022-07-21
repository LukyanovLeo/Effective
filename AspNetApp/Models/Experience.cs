using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetApp.Models
{
	public class Experience
	{
		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("job")]
		public string Job { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("position")]
		public string Position { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("period")]
		public string Period { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("duties")]
		public string[] Duties { get; set; }
	}
}