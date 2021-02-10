using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_008_ClasseSingleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaClasse_Click(object sender, EventArgs e)
        {
            Singleton s = Singleton.GetSingleton(Convert.ToInt32(txtValore.Text));
            MessageBox.Show("Valore s: "+s.val.ToString());
            Singleton s1 = Singleton.GetSingleton(Convert.ToInt32(0));
            MessageBox.Show("Valore s1: "+s1.val.ToString());
            MessageBox.Show("Valore s: " + s.val.ToString());
        }
    }   
}
