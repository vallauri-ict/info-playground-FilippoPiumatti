using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_MultiForm
{
    public partial class Form2 : Form
    {
        private int n;//visibile solo in form2

        private TextBox txt1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Costruttore Form2 con parametro INT
        /// </summary>
        /// <param name="n">Valore da salvare</param>
        public Form2 (int n)
        {
            InitializeComponent();
            this.n = n;//this si riferisce all'oggetto di Form2, devo specificare per omonimia
        }

        public Form2 (TextBox txt1)
        {
            InitializeComponent();
            this.txt1 = txt1;//this si riferisce all'oggetto di Form2, devo specificare per omonimia
        }

        private void bnLeggiValore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore: "+n);
        }

        private void btnInviaAF1_Click(object sender, EventArgs e)
        {
            txt1.Text = txtForm2.Text;
        }

        private void btnFormFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia f = new FormFiglia();//istanzio nuova form dinamica
            this.AddOwnedForm(f);//this è Form2, alla quale aggiungo f come form figlia
            f.Show();
        }
    }
}
