using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace _4_011_FormRegistrazione
{
    class InsiemeUtenti
    {
        private List<Utente> listaUtenti = new List<Utente>();
        //creo lista con soli nomi utente per controllo più rapidp
        private static List<String> nomiUtente = new List<String>();
        private static InsiemeUtenti instance = null;
        private string namefile;

        public InsiemeUtenti()
        {
        }

        public InsiemeUtenti(string namefile)
        {
            this.namefile = namefile;
        }

        public static InsiemeUtenti AggiungiUtente(Utente user, string filename)
        {
            if (instance == null)
            {
                instance = new InsiemeUtenti();
            }
            instance.listaUtenti.Add(user);
            nomiUtente.Add(user.user);
            ScriviSuFile(filename);
            return instance;
        }

        private static void ScriviSuFile(string filename)//potevo anche rendere globale costante
        {
            StreamWriter sw= new StreamWriter(filename, false);//false perchè devo riscrivere
            for (int i = 0; i < instance.listaUtenti.Count; i++)
            {
                sw.WriteLine(instance.listaUtenti[i].cognome + " " + instance.listaUtenti[i].nome + " " + instance.listaUtenti[i].citta + " " + instance.listaUtenti[i].indirizzo + " " + instance.listaUtenti[i].cap + " " + instance.listaUtenti[i].email + " " + instance.listaUtenti[i].user + " " + instance.listaUtenti[i].password);
            }
            sw.Close();
        }

        public static bool CercaUser(string username)
        {
            return nomiUtente.Contains(username);
        }
    }

}
