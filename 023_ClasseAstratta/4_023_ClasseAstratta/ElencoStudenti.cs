using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_023_ClasseAstratta
{
    class ElencoStudenti : Report
    {
        private List<Studente> lstStudenti = new List<Studente>();
        public string stampa = "";

        public ElencoStudenti()
        {
            //lstStudenti.Clear();
            lstStudenti.Add(new Studente("Andrea", "Giaccardi"));
            lstStudenti.Add(new Studente("Sergio", "Grosso"));
        }

        protected override void printBody()
        {
            foreach (var studente in lstStudenti)
            {
                stampa += studente.nomeCompleto()+"\n";
            }
        }

        protected override void printFooter()
        {
            stampa += "***********Footer stampa studenti***********\n";
        }

        protected override void printHeader()
        {
            stampa += "***********Intestazione stampa studenti***********\n";
        }
    }
}
