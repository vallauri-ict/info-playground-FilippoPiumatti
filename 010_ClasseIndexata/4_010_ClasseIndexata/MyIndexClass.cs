using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_010_ClasseIndexata
{
    class MyIndexClass
    {
        private string[] element;

        public MyIndexClass(int elementNumber)
        {
            element = new string[elementNumber];
            for (int i = 0; i < elementNumber; i++)
            {
                element[i] = "empty";//inizializzo stringa
            }
        }

        //Iteratore
        public string this[int pos]
        {
            get { return element[pos]; }//quando leggo item dell'oggetto leggo item dell'array di string dell'oggetto
            set { element[pos] = value; }//quando vado a modificare oggetto viene modificato array di string relativo all'oggetto
        }

        public int length()//restituisce la lunghezza della stringa relativa all'oggetto, e quindi anche la sua lunghezza
        {
            return element.Length;
        }
    }
}
