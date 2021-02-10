using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_023_ClasseAstratta
{
    class Studente
    {
        private string Nome{ get; set; }
        private string Cognome { get; set; }    
        private DateTime dataNascita;

        public Studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        /*public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public DateTime DataNascita1 { get => DataNascita; set => DataNascita = value; }*/

        public string nomeCompleto()
        {
            return Nome + " " + Cognome;
        }
   
    }
}
