using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_012_List
{
    class ClasseLibro
    {
        private string titolo;
        private string autore;
        private int id;
        private static List<ClasseLibro> listaLibri = new List<ClasseLibro>();

        private ClasseLibro(string titolo, string autore, int id)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.id = id;
        }

        public static ClasseLibro creaLibro(string titolo, string autore, int id)
        {
            if (String.IsNullOrWhiteSpace(titolo)||String.IsNullOrWhiteSpace(autore))//se int da messaggio della eccezione di default
            {
                throw new Exception("Errore nell'input");
            }
            else
            {
                ClasseLibro cl = new ClasseLibro(titolo, autore, id);
                listaLibri.Add(cl);
                return cl;
            }
            
        }

        public static void visualizzaLibri()
        {
            foreach (var item in listaLibri)
            {
                System.Windows.Forms.MessageBox.Show(item.titolo+" "+item.autore,item.id.ToString());
            }

        }

        public static void Find(string titolo)
        {
            ClasseLibro libroDaCercare;
            libroDaCercare=  listaLibri.Find(bf=>bf.titolo==titolo);
            if (libroDaCercare != null)
            {
                System.Windows.Forms.MessageBox.Show(libroDaCercare.titolo +" " +libroDaCercare.autore,"Trovato:" + libroDaCercare.id.ToString());
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nessun libro trovato con titolo " + titolo, "Nessuna corrispondenza");
            }
        }

        public static void FindAll(string titolo)
        {
            List<ClasseLibro> listaLibriTrovati = new List<ClasseLibro>();
            listaLibriTrovati = listaLibri.FindAll(bf => bf.titolo == titolo);
            if (listaLibriTrovati.Count!=0)
            {
                foreach (var item in listaLibriTrovati)
                {
                    System.Windows.Forms.MessageBox.Show(item.titolo + " " + item.autore, "Trovato:" + item.id.ToString());
                }
                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nessun libro trovato con titolo " + titolo, "Nessuna corrispondenza");
            }
        }
    }
}
