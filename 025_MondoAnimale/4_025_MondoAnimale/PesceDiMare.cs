using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    abstract class PesceDiMare:AnimaleMarino
    {
        public PesceDiMare(String s) : base(s)
        {
            this.verso = "non fa versi";
        }
        public override string si_muove()
        {
            return "nuotando";
        }
    }
}
