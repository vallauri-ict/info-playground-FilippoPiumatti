using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_009_PrintSpooler
{
    public partial class FormAggiungiFile : Form
    {
        public static string titolo;
        public static string autore;
        public static double prezzo;
        public FormAggiungiFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            titolo = txtTitolo.Text;
            autore = txtAutore.Text;
            prezzo = Convert.ToDouble(numPrezzo.Value);
            File f = null;
            try
            {
                f = File.CreaFile(titolo, autore, prezzo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (f != null)
            {
                Stampante.InviaStampante(f);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operazione annullata");
            this.Close();
        }
    }
}
