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
    public partial class Form1 : Form
    {
        public static DataGridView dataGV;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaElemento_Click(object sender, EventArgs e)
        {

            FormAggiungiFile ff = new FormAggiungiFile();
            ff.ShowDialog();
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            Stampante.StampaCoda();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGV = dataGridView1;
            inizializzaDgv(dataGV);
        }

        private void inizializzaDgv(DataGridView dgv)
        {
            string[] header = { "Indice", "Titolo", "Autore", "Prezzo" };
            dgv.ColumnCount = 4;
            //dgv.RowCount = 1 ; default, rimane una riga vuota dopo
            dgv.RowHeadersVisible = false;
            dgv.ClearSelection();
            dgv.ReadOnly = true;
            for (int i = 0; i < header.Length; i++)
            {
                dgv.Columns[i].HeaderText = header[i];
                dgv.Columns[i].Width = dgv.Width / 4;
            }
        }
    }
}
