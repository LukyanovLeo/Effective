using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy
{
	class Layer
	{
		public Node[] Nodes { get; set; }

	}

	class Node
	{
		public double[] Weights { get; set; } 

		public Dictionary<string, double> PreviousNodes { get; set; }

		public ActivationFunction ActivationFunction { get; set; }
	}

	public enum ActivationFunction
	{

	}
}
