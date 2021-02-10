using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_026_EsercizioStagisti
{
    abstract class ClsPersona
    {
        protected ClsPersona(string nome, string cognome, string citta)
        {
            Nome = nome;
            Cognome = cognome;
            Citta = citta;
        }

        #region attributes
        private string nome;
        private string cognome;
        private string citta;

        protected string Nome { get => nome; set
            {
                if (value.Trim().Length >= 2)
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("Input del nome errato");
                }
            }
        }
        protected string Cognome { get => cognome; set
            {
                if (value.Trim().Length >= 2)
                {
                    cognome = value;
                }
                else
                {
                    throw new Exception("Input del cognome errato");
                }
            }
        }
        protected string Citta { get => citta; set
            {
                if (value.Trim().Length >= 2)
                {
                    citta = value;
                }
                else
                {
                    throw new Exception("Input della città errato");
                }
            }
        }
        #endregion
        public abstract string Visualizza();
    }
}
