using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_009_PrintSpooler
{
    class File
    {
        public string titolo;
        public string autore;
        public double prezzo;

        private File(string titolo, string autore, double prezzo)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.prezzo = prezzo;
        }

        public static File CreaFile(string titolo, string autore, double prezzo)
        {
            if (String.IsNullOrWhiteSpace(titolo)|| (String.IsNullOrWhiteSpace(autore))||prezzo<0)
            {
                throw new Exception("Dati in input errati");
            }
            else
            {
                return new File(titolo, autore, prezzo);
            }
        }
    }
}
