using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_022_Scopa
{
    class Giocatore
    {
        private string nome;
        Mano mano;
        List<Carta> prese = new List<Carta>();    //di tipo mano? più corretto di tipo carta

        public Giocatore(string nome)
        {
            this.nome = nome;
            mano = new Mano();
            prese.Clear();
        }
        public Mano Lettura()
        {
            return mano;
        }

        public List<Carta> Prese()
        {
            return prese;
        }

        public void Gioca(int indice)
        {
            Carta giocata=mano.Gioca(indice);
        }
    }
}
