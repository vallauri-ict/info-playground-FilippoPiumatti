using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_024_EreditarietàCarte2
{
    class Carte
    {
        private string valore;
        private string seme;
        public string [] valori = { "Asso", "2", "3", "4", "5", "6", "7", "Fante", "Regina", "Re" };
        public string[] semi = { "Cuore", "Quadri", "Fiori", "Quadri"};

        public Carte(string valore, string seme)
        {
            Valore = valore;
            Seme = seme;
        }

        public Carte()
        {
        }

        public string Valore
        {
            get => valore;
            set
            {
                if (valori.Contains(value))
                {
                    valore = value;

                }
                else
                {
                    throw new Exception("Errore nell'input del valore");
                }
            }
        }
        public string Seme { get => seme; set
            {
                if (semi.Contains(value))
                {
                    seme = value;

                }
                else
                {
                    throw new Exception("Errore nell'input del seme");
                }
            }
        }
    }
}
