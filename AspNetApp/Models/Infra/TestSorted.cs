using AspNetApp.Models.XmlModel;
using System.Collections.Generic;

namespace AspNetApp.Models.Infra
{
	public class TestSorted
	{
		public string Name { get; set; }

		public string TestedPerson { get; set; }

		public Time Time { get; set; } = new Time();

		public string CurrentTime { get; set; }

		public int AttemptNumber { get; set; }

		public List<BaseAnswer> Questions { get; set; }
	}
}