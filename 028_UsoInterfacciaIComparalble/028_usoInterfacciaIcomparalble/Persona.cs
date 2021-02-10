using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_usoInterfacciaIcomparalble
{
    class Persona:IComparable
    {
        private string nome;
        private string cognome;
        private string citta;

        public Persona(string nome, string cognome, string citta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.citta = citta;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Citta { get => citta; set => citta = value; }

       public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Persona p = obj as Persona;
            return String.Compare(Cognome, p.cognome, true);
        }
        public override string ToString()
        {
            return Cognome + " " + Nome + " " + Citta;
        }
    }
}
