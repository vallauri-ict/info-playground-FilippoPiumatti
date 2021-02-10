using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_003_MultiFormMenu
{
    public partial class Form2 : Form
    {
        private int n;
        private bool activate = false;

        private TextBox txt1;
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Costruttore Form2 con parametro INT
        /// </summary>
        /// <param name="n">Valore da salvare</param>
        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
        }

        public Form2(TextBox txt1)
        {
            InitializeComponent();
            activate = true;
            this.txt1 = txt1;
        }


        private void leggiValoreBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore: " + n);
            toolStripLbl.Text = "Lettura valore";
        }

        private void inviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (activate)
            {
                txt1.Text = txtValue.Text;
            }
            else
            {
                MessageBox.Show("Per passare un valore alla Form1 scegliere 'passa Txt a Forn2'");
            }
            toolStripLbl.Text = "Passaggio testo a Form1";
        }

        private void apriFormFigliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiglia f = new FormFiglia();//form dinamica
            this.AddOwnedForm(f);
            f.Show();
            toolStripLbl.Text = "Apertura Form Figlia";
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModalEsci f = new FormModalEsci();
            f.Text = "Uscire";
            if (f.ShowDialog() == DialogResult.Yes)
            {
                Close();
            }
            toolStripLbl.Text = "Uscita";
        }
    }
}
