using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    class Tonno : PesceDiMare
    {
        
        public Tonno(String s) : base(s)
        {
            
        }
        public override string chi_sei()
        {
            return "un tonno";
        }


        public override string vive()
        {
            return base.vive();
        }
    }
}
