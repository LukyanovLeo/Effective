using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace AspNetApp.Models
{
	public class Loan
	{
		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("totalAmount")]
		public double TotalAmount { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("paidAmount")]
		public double PaidAmount { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("loanPurpose")]
		public string LoanPurpose { get; set; }

		[Required(ErrorMessage = "Вы не ответили на вопрос 1")]
		[BsonElement("creditor")]
		public string Creditor { get; set; }
	}
}