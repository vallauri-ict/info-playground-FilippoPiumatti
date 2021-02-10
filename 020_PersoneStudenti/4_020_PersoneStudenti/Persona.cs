using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_020_PersoneStudenti
{
    class Persona
    {
        private string nome, cognome, sesso;
        private int eta;

        public void SetAttributes(string nome, string cognome, string sesso, int eta)
        {
            if (String.IsNullOrWhiteSpace(nome)||String.IsNullOrWhiteSpace(cognome)||String.IsNullOrWhiteSpace(sesso)||eta<0)
            {
                throw new Exception("Inserire i campi corretti!");
            }
            else
            {
                this.nome = nome;
                this.cognome = cognome;
                this.sesso = sesso;
                this.eta = eta;
            }
        }

        public string GetNome()
        {
            return this.nome;
        }
        public string GetCognome()
        {
            return this.cognome;
        }
        public string GetSesso()
        {
            return this.sesso;
        }
        public int GetEta()
        {
            return this.eta;
        }
        public void GetAttributes(out string nome, out string cognome, out string sesso, out int eta)//utilizzo out
        {
            nome = this.nome;
            cognome = this.cognome;
            sesso = this.sesso;
            eta = this.eta;
        }
    }
}
