using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_009_PrintSpooler
{
    class Stampante
    {
        public File fileStampa;
        public Queue<File> codaStampa=new Queue<File>();
        private static Stampante instance = null;

        private Stampante()
        {
        }

        public Stampante(File fileStampa)
        {
            this.fileStampa = fileStampa;
        }

        public static Stampante InviaStampante(File fileStampa)
        {
            if (instance == null)
            {
                instance = new Stampante(fileStampa);
            }
            instance.codaStampa.Enqueue(fileStampa);
            mostraSuDgv();
            return instance;
        }

        private static void mostraSuDgv()
        {
            Form1.dataGV.Rows.Clear();
            for (int i = 0; i < instance.codaStampa.Count; i++)
            {
                Form1.dataGV.Rows.Add();
                Form1.dataGV.Rows[i].Cells[0].Value = (i+1).ToString();
                Form1.dataGV.Rows[i].Cells[1].Value = instance.codaStampa.ElementAt(i).titolo;
                Form1.dataGV.Rows[i].Cells[2].Value = instance.codaStampa.ElementAt(i).autore;
                Form1.dataGV.Rows[i].Cells[3].Value = instance.codaStampa.ElementAt(i).prezzo.ToString();
                
            }
            
        }
        

        public static void StampaCoda()
        {
            File fileDaStampare;
            while (instance.codaStampa.Count!=0)
            {
                fileDaStampare = instance.codaStampa.Peek();
                System.Windows.Forms.MessageBox.Show("Stampa in corso di "+fileDaStampare.titolo+" di "+fileDaStampare.autore +". Prezzo: "+fileDaStampare.prezzo.ToString()+"€");
                instance.codaStampa.Dequeue();
                //Form1.dataGV.Rows.Clear();
                mostraSuDgv();//così dovrebbe togliere un item alla volta, con un miglior effetto grafico
            }
        }
    }
}
