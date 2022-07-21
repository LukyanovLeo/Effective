using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetApp.Models
{
	public class Candidate
	{
		[BsonElement("_id")]
		public ObjectId Id { get; set; }

		[BsonElement("name")]
		public string Name { get; set; }

		[BsonElement("surname")]
		public string Surname { get; set; }

		[BsonElement("patronymic")]
		public string Patronymic { get; set; }
		
		[BsonElement("gender")]
		public bool Sex { get; set; }

		[BsonElement("birthdate")]
		public string BirthDate { get; set; }

		public string Citizenship { get; set; }

		public string Phone { get; set; }

		[Required(ErrorMessage = "Вы не ввели дополнительный телефон")]
		public string AdditionalPhone { get; set; }

		[Required(ErrorMessage = "Вы не ввели семейное положение")]
		[BsonElement("maritalStatus")]
		public string MaritalStatus { get; set; }

		[BsonElement("childrenCount")]
		public int ChildrenCount { get; set; }

		[BsonElement("children")]
		public Children[] Children { get; set; }

		[Required(ErrorMessage = "Вы не ввели адрес по документам")]
		[BsonElement("legalAddress")]
		public Address LegalAddress { get; set; }

		[Required(ErrorMessage = "Вы не ввели фактический адрес")]
		[BsonElement("actual_address")]
		public Address ActualAddress { get; set; }

		[BsonElement("illnesses")]
		public Illness[] Illnesses { get; set; }

		[Required(ErrorMessage = "Вы не ввели данные о кредитах")]
		[BsonElement("outstandingLoans")]
		public Loan[] OutstandingLoans { get; set; }

		[Required(ErrorMessage = "Вы не ввели данные о семье")]
		public FamilyMember[] Family { get; set; }

		[Required(ErrorMessage = "Вы не ввели данные об образовании")]
		[BsonElement("university")]
		public University[] University { get; set; }

		[Required(ErrorMessage = "Вы не ввели данные об доп. курсах")]
		[BsonElement("additionalCourses")]
		public Course[] Courses { get; set; }

		[BsonElement("driverLicense")]
		public DriverLicence DriverLicence { get; set; }
		
		[Required(ErrorMessage = "Вы не ввели данные о патентах")]
		[BsonElement("patents")]
		public Patent[] Patents { get; set; }

		[BsonElement("scientificDegrees")]
		public string[] ScientificDegrees { get; set; }

		[Required(ErrorMessage = "Вы не ввели данные о публикациях")]
		[BsonElement("publications")]
		public Publication[] Publications { get; set; }

		[Required(ErrorMessage = "Вы не ввели данные о правонарушениях")]
		[BsonElement("offences")]
		public Offence[] Offences { get; set; }

		[Required(ErrorMessage = "Вы не ввели данные об опыте работы")]
		[BsonElement("experience")]
		public Experience Experience { get; set; }

		[Required(ErrorMessage = "Вы не ввели данные о службе в армии")]
		[BsonElement("armyService")]
		public ArmyService ArmyService { get; set; }

		[Required(ErrorMessage = "Вы не ввели ваши навыки")]
		[BsonElement("skills")]
		public string[] Skills { get; set; }

		[BsonElement("recomendations")]
		public string[] Recomendations { get; set; }
	}
}