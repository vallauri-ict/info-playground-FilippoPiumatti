using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    class Pinguino:Uccello
    {
        public Pinguino(String s) : base(s)
        {
            this.verso = "non fa versi";
        }
        public override string chi_sei()
        {
            return "un pinguino";
        }
        public override string si_muove()
        {
            return "ma non sa volare";
        }
        public override string vive()
        {
            return "al polo";
        }
    }
}
