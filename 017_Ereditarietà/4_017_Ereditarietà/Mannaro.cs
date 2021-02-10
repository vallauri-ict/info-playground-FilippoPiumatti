using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_017_Ereditarietà
{
    class Mannaro : Mostro
    {
        protected bool mutato;

        public Mannaro()
        {
            punti = 33;
            verso = "ululato";
            mutato = true;
        }

        public double Valore()
        {
            return mutato ? 2 * base.Valore() : base.Valore();
        }
        public string Verso()
        {
            return mutato ? verso : base.verso;//posso accedere a verso anceh se private
        }
        public void Muta()
        {
            mutato = !mutato;
        }
    }
}
