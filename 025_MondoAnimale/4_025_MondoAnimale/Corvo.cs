using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    class Corvo:Uccello
    {
        public Corvo(String s) : base(s)
        {
            this.verso = "gracchia";
        }
        public override string chi_sei()
        {
            return "un corvo";
        }
    }
}
