using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_007_MetodoFactory
{
    class Quadrato
    {
        private int lato;

        private Quadrato(int lato)
        {
            this.lato = lato;
        }

        /*utilizzo metodo factory per controllare che i dati di input siano corretti prima di 
         creare un'oggetto con valori non validi, mentre costruttore crea sempre*/
        public static Quadrato creaQuadrato(int lato)
        {
            if (lato<=0)
            {
                throw new Exception("Il lato deve essere maggiore di 0");
            }
            else
            {
                return new Quadrato(lato);
            }
        }
    }
}
