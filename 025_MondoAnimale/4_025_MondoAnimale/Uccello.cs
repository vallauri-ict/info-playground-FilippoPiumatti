using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    abstract class Uccello:Animale // non derivo da animale terrestre perchè non hanno nulla in comune
    {
		public Uccello(String s) : base(s)
		{

		}

		public override String vive()
		{
			return "in un nido su un albero";
		}

		public override String chi_sei()
		{
			return "un uccello";
		}

        public override string si_muove()
        {
			return "volando";
        }
	}
}
