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
    public partial class FormFiglia : Form
    {
        public FormFiglia()
        {
            InitializeComponent();
        }

        private void btnGenitore_Click(object sender, EventArgs e)
        {
            if (Owner!=null)
            {
                MessageBox.Show("Form figlia di "+this.Owner.Text);//stampo titolo dell'oggetto della Form Padre
            }
        }
    }
}
