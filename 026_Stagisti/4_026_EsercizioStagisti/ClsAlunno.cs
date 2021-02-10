using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_026_EsercizioStagisti
{
    class ClsAlunno:ClsPersona
    {
        #region attributes
        protected static int progressivo = 0;
        private readonly string matricola;
        private char classe;
        private char sezione;
        private string specializzazione;

        protected string Matricola => matricola;
        protected char Classe { get => classe; set => classe = Convert.ToChar(value); }
        protected char Sezione { get => sezione; set => sezione = Convert.ToChar(value); }
        protected string Specializzazione { get => specializzazione; set => specializzazione = value; }
        #endregion
        public ClsAlunno(string nome, string cognome, string citta, int classe, string sezione, string specializzazione) : base(nome, cognome, citta)
        {
            Classe = Convert.ToChar(classe);
            Specializzazione = specializzazione;
            Sezione = Convert.ToChar(sezione);
            progressivo++;
            matricola = "A" + progressivo.ToString().PadLeft(5, '0');
        }
        public override string Visualizza() {
            return $"{Nome} {Cognome} {Citta} {Classe} {Sezione} {Specializzazione}";
        }
    }
}
