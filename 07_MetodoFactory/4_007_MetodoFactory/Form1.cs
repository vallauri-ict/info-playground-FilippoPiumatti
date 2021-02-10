using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_007_MetodoFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaQuadrato_Click(object sender, EventArgs e)
        {
            Quadrato q;

            if (!String.IsNullOrWhiteSpace(txtLatoQuadrato.Text))
            {
                try
                {
                    q = Quadrato.creaQuadrato(Convert.ToInt32(txtLatoQuadrato.Text));
                }
                catch (Exception ex)//cattura anche l'eccezione eventualmente generata da convert errati su lettere
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Inserire un lato valido!");
            }
        }
    }
}
