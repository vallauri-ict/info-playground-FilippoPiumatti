using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_024_EreditarietàCarte2
{
    class MazzoCarte
    {
        private List<Carte> mazzo = new List<Carte>();
        Random rnd = new Random();

        public MazzoCarte()
        {
            Carte aus = new Carte();
            foreach (var seme in aus.semi)
            {
                foreach (var valore in aus.valori)
                {
                    Carte carta = new Carte(valore, seme);
                    mazzo.Add(carta);
                }
            }
            
                
            
        }

        public void InserisciCarta(string valore, string seme)
        {
            Carte carta = new Carte();
            carta.Seme = seme;
            carta.Valore = valore;
            if (mazzo.Find(bf => bf.Valore == valore && bf.Seme == seme)==null)
            {
                mazzo.Add(carta);
                System.Windows.Forms.MessageBox.Show("Carta inserita");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Carta già presente");
            }
        }
        public Carte DammiCarta()
        {
            Carte aus = mazzo.First();
            mazzo.RemoveAt(0);
            return aus;
        }
        public int DammiCarta(string valore, string seme)
        {
            Carte aus = mazzo.Find(bf => bf.Valore == valore && bf.Seme == seme);
            return mazzo.IndexOf(aus);
        }
        public void MescolaCarte()
        {
            Carte aus;
            int l = mazzo.Count;//per evitare errore sulla modifica della lista
            for (int i = 0; i < l; i++)//mischio per ogni carta
            {
                aus = mazzo.First();
                mazzo.Remove(mazzo.First());
                mazzo.Insert(rnd.Next(1, l), aus);
            }
        }
    }
}
