using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_026_EsercizioStagisti
{
    class ClsStagista : ClsAlunno
    {
        #region attributi
        private string azienda;
        private int ore;

        internal string Azienda { get => azienda; set => azienda = value; }//internal visibile all'interno del namespace
        internal string Ore { 
            get { return ore.ToString(); }
            set
            {
                if (Convert.ToInt32(value) < 1)
                {
                    throw new Exception("Numero di ore non valido");
                }
                else
                {
                    ore = Convert.ToInt32(value);
                }
            }

        }

        public ClsStagista(string nome, string cognome, string citta, int classe, string sezione, string specializzazione, string azienda, string ore):base(nome, cognome, citta, classe, sezione, specializzazione)
        {
            Azienda = azienda;
            Ore = ore;
        }

        public override string Visualizza()
        {
            return $"{base.Visualizza()} {azienda} {ore}";
        }


        #endregion
    }
}
