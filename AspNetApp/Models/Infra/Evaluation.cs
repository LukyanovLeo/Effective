using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AspNetApp.Models.Infra
{
	public class Evaluation
	{
		[JsonProperty("Efficiency")]
		public double Efficiency { get; set; }
		[JsonProperty("Loyalty")]
		public double Loyalty { get; set; }
		[JsonProperty("Sufficiency")]
		public double Sufficiency { get; set; }
		[JsonProperty("Is_1")]
		public double? Is_1 { get; set; }
		[JsonProperty("Is_2")]
		public double? Is_2 { get; set; }
		[JsonProperty("Is_3")]
		public double? Is_3 { get; set; }
		[JsonProperty("Is_4")]
		public double? Is_4 { get; set; }
		[JsonProperty("Is_5")]
		public double? Is_5 { get; set; }
		[JsonProperty("Is_6")]
		public double? Is_6 { get; set; }
		[JsonProperty("Is_7")]
		public double? Is_7 { get; set; }
		[JsonProperty("Is_8")]
		public double? Is_8 { get; set; }
		[JsonProperty("Is_9")]
		public double? Is_9 { get; set; }
		[JsonProperty("Is_10")]
		public double? Is_10 { get; set; }
	}
}