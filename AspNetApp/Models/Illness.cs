using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetApp.Models
{
	public class Illness
	{
		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("name")]
		public string Name { get; set; }
		
		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("detectionDate")]
		public string DetectionDate { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("recoveryDate")]
		public string RecoveryDate { get; set; }
	}
}