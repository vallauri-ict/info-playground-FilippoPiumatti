using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_020_PersoneStudenti
{
    class Studente : Persona
    {
        List<int> voti = new List<int>();
        
        public double Media()
        {
            if (voti.Count == 0)
            {
                Exception ex = new Exception("Non ci sono voti inseriti");
                throw (ex);
            }
            int somma=0;
            foreach (var item in voti)
            {
                somma += item;
            }
            return (double)(somma / voti.Count());
        }

        public void AggiungiVoto(int voto)
        {
            this.voti.Add(voto);
        }

        public int GetNumeroVoti()
        {
            return this.voti.Count();
        }
    }
}
