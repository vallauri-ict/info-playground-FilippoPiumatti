using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    abstract class Quadrupede : AnimaleTerrestre
    {
		public Quadrupede(String s) : base(s)
		{

		}

		public override string si_muove()
		{
			return "avanzando su 4 zampe";
		}

	}
}
