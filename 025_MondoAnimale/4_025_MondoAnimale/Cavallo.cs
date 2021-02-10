using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    class Cavallo:Quadrupede
    {
        public Cavallo(String s) : base(s)
        {
            this.verso = "nitrisce";
        }
        public override string chi_sei()
        {
            return "un cavallo";
        }
    }
}
