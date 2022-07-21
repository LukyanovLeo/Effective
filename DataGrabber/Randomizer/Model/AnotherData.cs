using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetApp.Randomizer.Model
{
	public partial class CandidateData
	{
		public static List<string> Citizenships { get; private set; } = new List<string>
		{
			"РФ",
			"Беларусь",
			"Украина",
		};

		public static List<string> MaritalStatus { get; private set; } = new List<string>
		{
			"Женат",
			"Холост",
			"Разведён",
			"Состою в гражданском браке",
		};
	}
}