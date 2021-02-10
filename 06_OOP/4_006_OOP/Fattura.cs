using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_006_OOP
{
    class Fattura
    {
        private static int cntFatture;
        public readonly int nFattura;
        public Fattura()
        {
            cntFatture++;
            this.nFattura = cntFatture;
        }
        public static void visualizza()
        {
            System.Windows.Forms.MessageBox.Show("Fattura numero: " + cntFatture);
        }
    }
}
