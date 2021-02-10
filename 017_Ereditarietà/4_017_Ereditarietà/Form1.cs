using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_017_Ereditarietà
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostro_Click(object sender, EventArgs e)
        {
            Mostro demone = new Mostro();
            MessageBox.Show(demone.Valore().ToString()+" "+demone.Verso());
        }

        private void BtnMannaro_Click(object sender, EventArgs e)
        {
            Mannaro umano = new Mannaro();
            MessageBox.Show(umano.Valore().ToString() + " " + umano.Verso());
            umano.Muta();
            MessageBox.Show(umano.Valore().ToString() + " " + umano.Verso());
        }
    }
}
