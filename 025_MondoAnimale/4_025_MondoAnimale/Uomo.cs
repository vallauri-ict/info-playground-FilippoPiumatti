using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    class Uomo:Bipede
    {
        public Uomo(String s) : base(s)
        {
            this.verso = "parla";
        }
        public override string chi_sei()
        {
            return "un homo sapiens";
        }
        public override string vive()
        {
            return "in un condominio";
        }
    }
}
