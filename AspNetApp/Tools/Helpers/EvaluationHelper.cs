using AspNetApp.Models.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AspNetApp.Tools.Helpers
{
	public class EvaluationHelper
	{
		public static Evaluation ParseEvaluation(string json)
		{
			var eval = JsonConvert.DeserializeObject<Evaluation>(json);			
			eval.Loyalty = Math.Truncate((eval.Loyalty % 1) * 100);
			eval.Sufficiency = Math.Truncate((eval.Sufficiency) % 1 * 100);
			var mean = (eval.Loyalty + eval.Sufficiency) / 2;
			eval.Efficiency = Math.Truncate((mean % 1) * 100);
			eval.Is_1 = ((eval.Is_1 % 1) * 100) ?? null;
			eval.Is_2 = ((eval.Is_2 % 1) * 100) ?? null;
			eval.Is_3 = ((eval.Is_3 % 1) * 100) ?? null;
			eval.Is_4 = ((eval.Is_4 % 1) * 100) ?? null;
			eval.Is_5 = ((eval.Is_5 % 1) * 100) ?? null;
			eval.Is_6 = ((eval.Is_6 % 1) * 100) ?? null;
			eval.Is_7 = ((eval.Is_7 % 1) * 100) ?? null;
			eval.Is_8 = ((eval.Is_8 % 1) * 100) ?? null;
			eval.Is_9 = ((eval.Is_9 % 1) * 100) ?? null;
			eval.Is_10 = ((eval.Is_10 % 1) * 100) ?? null;
			return eval;
		}
	}
}