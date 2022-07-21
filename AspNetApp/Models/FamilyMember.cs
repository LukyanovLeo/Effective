using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetApp.Models
{
	public class FamilyMember
	{
		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("actual_address")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("actual_address")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("actual_address")]
		public string Patronymic { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("actual_address")]
		public DateTime Birthdate { get; set; }
	}
}