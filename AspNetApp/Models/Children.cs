using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetApp.Models
{
	public class Children
	{
		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("name")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("birthdate")]
		public string BirthDate { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("gender")]
		public bool Sex { get; set; }
	}
}