using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace AspNetApp.Models
{
	public class University
	{
		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("name")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("speciality")]
		public string Speciality { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("redDiploma")]
		public bool RedDiploma { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("meanScore")]
		public double MeanScore { get; set; }
	}
}