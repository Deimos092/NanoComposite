using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoComposite
{
	public class Material
	{
		public Material() {  }

		public string Name { get; set; }
		public double Hardness { get; set; }
		public double Elasticity { get; set; }
		public double StrengthBeyond { get; set; }
		public double Density { get; set; }
		public double HeatCapacity { get; set; }
		public double ThermalConduct { get; set; }
		public double ThermalExpansion { get; set; }
		public double Percent { get; set; }
		public bool isMatrix { get; set; }
	}
}
