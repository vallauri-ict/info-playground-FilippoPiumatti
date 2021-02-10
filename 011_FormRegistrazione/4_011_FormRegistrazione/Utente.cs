using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_011_FormRegistrazione
{
    class Utente
    {
        public string cognome;
        public string nome;
        public string indirizzo;
        public string citta;
        public string cap;
        public string email;
        public string user;
        public string password;
        
        

        private Utente()
        {
        }

        private Utente(string cognome, string nome, string indirizzo, string citta, string cap, string mail, string user, string password)
        {
            this.cognome = cognome;
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.citta = citta;
            this.cap = cap;
            this.email = mail;
            this.user = user;
            this.password = password;
        }

        public static Utente creaUtente(string cognome, string nome, string indirizzo, string citta, string cap, string mail, string user, string password)
        {
            if (!InsiemeUtenti.CercaUser(user))
            {
                Utente utente = new Utente(cognome, nome, indirizzo, citta, cap, mail, user, password);
                return utente;
            }
            else
            {
                throw new Exception("Nome utente già presente");
            }
            
        }


    }
}
