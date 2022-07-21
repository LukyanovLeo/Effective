using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetApp.Models
{
	public class ArmyService
	{
		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("militaryUnit")]
		public string MilitaryUnit { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("armyType")]
		public string ArmyType { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("rank")]
		public string Rank { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("speciality")]
		public string Speciality { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("awards")]
		public string Awards { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("serviceStartDate")]
		public string ServiceStartDate { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("serviceEndDate")]
		public string ServiceEndDate { get; set; }
	}
}