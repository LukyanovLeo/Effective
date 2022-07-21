using AspNetApp.Models;
using AspNetApp.Randomizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetApp.Tools
{
	public class DbTools
	{
		public static string WriteRandomCandidateToDb(bool isWomen)
		{
			var candidate = new Candidate();
			var rand = new Random();

			string result = "";

			#region Name

			if (isWomen)
			{

			}
			else
			{
				int randNameIndex = rand.Next(CandidateData.MaleNames.Count);
				int randSurnameIndex = rand.Next(CandidateData.Surnames.Count);
				int randPatronymicIndex = rand.Next(CandidateData.Surnames.Count);

				candidate.Name = CandidateData.MaleNames[randSurnameIndex];
				candidate.Surname = CandidateData.Surnames[randSurnameIndex];
				candidate.Patronymic = CandidateData.MalePatronymics[randPatronymicIndex];
			}

			#endregion

			#region Birth date

			var from = new DateTime(1945, 1, 1);
			var to = new DateTime(1998, 12, 31);
			var range = (to - from).Days;

			candidate.BirthDate = from.AddDays(rand.Next(range)).ToString();

			#endregion

			#region Sex

			candidate.Sex = isWomen;

			#endregion

			#region Citizenship

			candidate.Citizenship = CandidateData.Citizenships[rand.Next(CandidateData.MaleNames.Count)];

			#endregion

			#region Phone

			candidate.Phone = "79689247633";

			#endregion

			#region Marital status

			candidate.MaritalStatus = "";

			#endregion

			#region Address

			// TODO: добавить API для подсчета расстояний

			#endregion

			#region Illnesses



			#endregion



			return result;
		}
	}
}