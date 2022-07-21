using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetApp.Data
{
	public class Advices
	{
		public static List<string> Descriptions { get; private set; } = new List<string>()
		{
			"Делать разминку",
			"Составить план",
			"Познакомиться с коллегами",
			"Работать из дома",
		};
	}
}