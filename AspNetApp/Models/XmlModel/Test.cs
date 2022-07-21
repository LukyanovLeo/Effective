using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AspNetApp.Models.XmlModel
{
	[XmlRoot(Namespace = "candidate-test", ElementName = "test")]
	public class Test
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }

		[XmlElement(ElementName = "time")]
		public Time Time { get; set; }

		[XmlElement(ElementName = "attemptNumber")]
		public int AttemptNumber { get; set; }

		[XmlElement(ElementName = "questions")]
		public Questions Questions { get; set; }
	}

	public class Time
	{
		[XmlElement(ElementName = "hours")]
		public int Hours { get; set; }

		[XmlElement(ElementName = "minutes")]
		public int Minutes { get; set; }

		[XmlElement(ElementName = "seconds")]
		public int Seconds { get; set; }
	}

	public class Questions
	{
		[XmlElement(ElementName = "singles")]
		public Singles SingleAnswers { get; set; }

		[XmlElement(ElementName = "multiples")]
		public Multiples MultipleAnswers { get; set; }

		[XmlElement(ElementName = "inputs")]
		public Inputs InputAnswers { get; set; }

		[XmlElement(ElementName = "frees")]
		public Frees FreeAnswers { get; set; }
	}

	/////////////////////////////////////////////////

	public class Singles
	{
		[XmlElement(ElementName = "single")]
		public List<SingleAnswer> SingleAnswers { get; set; }
	}

	public class Multiples
	{
		[XmlElement(ElementName = "multiple")]
		public List<MultipleAnswer> MultipleAnswers { get; set; }
	}

	public class Inputs
	{
		[XmlElement(ElementName = "input")]
		public List<InputAnswer> InputAnswers { get; set; }
	}

	public class Frees
	{
		[XmlElement(ElementName = "free")]
		public List<FreeAnswer> FreeAnswers { get; set; }
	}

	/////////////////////////////////////////////////

	public class BaseAnswer
	{
		[XmlElement(ElementName = "number")]
		public int Number { get; set; }

		[XmlElement(ElementName = "text")]
		public string Text { get; set; }

		[XmlElement(ElementName = "weight")]
		public int Weight { get; set; }

		[XmlElement(ElementName = "category")]
		public string Category { get; set; }

		[XmlIgnore]
		public int SecondsToAnswer { get; set; }

		[XmlIgnore]
		public string GivenAnswer { get; set; }

		[XmlIgnore]
		public List<bool> MultipleAnswers { get; set; }
	}

	/////////////////////////////////////////////////

	public class SingleAnswer : BaseAnswer
	{
		[XmlElement(ElementName = "answer")]
		public List<string> Answers { get; set; }

		[XmlElement(ElementName = "trueAnswer")]
		public string TrueAnswer { get; set; }

		[XmlIgnore]
		public string Choice { get; set; }
	}

	public class MultipleAnswer : BaseAnswer
	{
		[XmlElement(ElementName = "answer")]
		public List<string> Answers { get; set; }

		[XmlElement(ElementName = "trueAnswers")]
		public List<string> TrueAnswers { get; set; }

		[XmlIgnore]
		public Dictionary<string, bool> Choices { get; set; }
	}

	public class InputAnswer : BaseAnswer
	{
		[XmlElement(ElementName = "trueAnswer")]
		public string TrueAnswer { get; set; }

		[XmlIgnore]
		public string Answer { get; set; }
	}

	public class FreeAnswer : BaseAnswer
	{
		[XmlIgnore]
		public string Answer { get; set; }
	}
}
