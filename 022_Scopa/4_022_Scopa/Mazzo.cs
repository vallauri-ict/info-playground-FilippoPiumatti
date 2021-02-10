using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_022_Scopa
{
    //dovrebbe essere singleton? non specificato
    class Mazzo
    {
        List<Carta> mazzo = new List<Carta>();//lista per mischiare
        Random rnd = new Random();

        public Mazzo()
        {
            for (int i = 1; i < 11; i++)
            {
                Carta card = new Carta("Denari", i);
                mazzo.Add(card);
            }
            for (int i = 1; i < 11; i++)
            {
                Carta card = new Carta("Bastoni", i);
                mazzo.Add(card);
            }
            for (int i = 1; i < 11; i++)
            {
                Carta card = new Carta("Spade", i);
                mazzo.Add(card);
            }
            for (int i = 1; i < 11; i++)
            {
                Carta card = new Carta("Coppe", i);
                mazzo.Add(card);
            }
        }
        public void Mescola()
        {
            Carta aus;
            int l = mazzo.Count;//per evitare errore sulla modifica della lista
            for (int i = 0; i < l; i++)//mischio per ogni carta
            {
                aus = mazzo.First();
                mazzo.Remove(mazzo.First());
                mazzo.Insert(rnd.Next(1,l),aus);
            }
        }
        public Carta Estrai()
        {
            //restituisco ed elimino
            Carta aus = mazzo.First();
            mazzo.RemoveAt(0);
            return aus;
        }
    }
}
