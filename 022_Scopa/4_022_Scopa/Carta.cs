using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_022_Scopa
{
    class Carta
    {
        private string seme;
        private int valore;

        public Carta(string seme, int valore)
        {
            this.seme = seme;
            this.valore = valore;
        }
        public void Lettura(out string seme, out int valore)
        {
            seme = this.seme;
            valore = this.valore;
        }
    }
}
