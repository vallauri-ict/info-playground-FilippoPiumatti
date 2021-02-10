using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_026_EsercizioStagisti
{
    sealed class ClsElenco
    {
        List<ClsAlunno> elenco;

        public ClsElenco()
        {
            elenco = new List<ClsAlunno>();
        }

        #region metodi
        public void Inserisci(ClsAlunno alunno)
        {
            elenco.Add(alunno);
        }
        public void VisualizzaDgv(DataGridView dgv)
        {
            dgv.DataSource = typeof(List<>);
            //permette import secondo elementi della Lista
            dgv.DataSource = elenco;
        }
        public int OreAziende(string nome)
        {
            int totaleOre=0;
            foreach (var item in elenco)
            {
                if (item is ClsStagista)
                {
                    ClsStagista stag = item as ClsStagista;//converto in ClsStagista --> ClsStagista stag = (ClsStagista) item;
                    if (stag.Azienda == nome)
                    {
                        totaleOre += Convert.ToInt32(stag.Ore);
                    }
                }
            }
            return totaleOre;
        } 

        /// <summary>
        /// Cancella tutto l'elenco
        /// </summary>
        public void Cancella()
        {
            if (elenco.Count==0)
            {
                throw new Exception("Elenco già vuoto");
            }
            else
            {
                elenco.Clear();
            }
            //elenco.Clear();
        }

        /// <summary>
        /// Rimuove l'elemento nella posizione passata come parametro
        /// </summary>
        /// <param name="posizione">La posizione dell'elemento da eliminare</param>
        public void Cancella1(int posizione)
        {
            posizione--;
            if (elenco.Count == 0)
            {
                throw new Exception("Elenco vuoto");
            }
            else if (posizione<0||posizione>elenco.Count-1)
            {
                throw new Exception("Posizione non valida");
            }
            else
            {
                elenco.RemoveAt(posizione);
            }
        }
        #endregion
    }
}
