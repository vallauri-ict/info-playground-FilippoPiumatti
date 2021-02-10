using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    abstract class AnimaleTerrestre:Animale
    {
		public AnimaleTerrestre(String s) : base(s)
		{

		}

		public override String vive()
		{
			return "sulla terra ferma";
		}

		public override String chi_sei()
		{
			return "un animale terrestre";
		}
	}
}
