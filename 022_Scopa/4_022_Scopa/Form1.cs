using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_022_Scopa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Mazzo mazzo;
        private void button1_Click(object sender, EventArgs e)
        {
            mazzo = new Mazzo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string seme;
            int val;
            mazzo.Mescola();
            Carta aus = mazzo.Estrai();
            aus.Lettura(out seme, out val);
            MessageBox.Show(val +" di "+seme);
        }
    }
}
