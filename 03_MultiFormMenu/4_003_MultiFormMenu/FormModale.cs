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
    public partial class FormModale : Form
    {
        public string nome = "";
        public string eta = ""; 
        public FormModale()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            eta = txtEta.Text;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            nome = "";
            eta = "";
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void txtEta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
