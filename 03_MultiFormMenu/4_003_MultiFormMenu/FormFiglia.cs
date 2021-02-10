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
    public partial class FormFiglia : Form
    {
        public FormFiglia()
        {
            InitializeComponent();
        }

        private void btnCercaPadre_Click(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                MessageBox.Show("Form Padre: " + this.Owner.Text);
            }
        }
    }
}
