using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetApp.Models
{
	public class Patent
	{
		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("name")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("scope")]
		public string Scope { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("registrationDate")]
		public string RegistrationDate { get; set; }
	}
}