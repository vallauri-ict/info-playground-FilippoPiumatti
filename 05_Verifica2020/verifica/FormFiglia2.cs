using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaccaPaolo
{
    public partial class FormFiglia2 : Form
    {
        public FormFiglia2()
        {
            InitializeComponent();
        }

        private void FormFiglia2_Load(object sender, EventArgs e)
        {
            {
                MessageBox.Show(formMain.datiForm);
            }
            
        }
    }
}
