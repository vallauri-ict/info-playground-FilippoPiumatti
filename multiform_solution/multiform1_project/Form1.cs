using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizio1_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();//istanzio la form
            f2.Show();// mostro la form
        }

        private void btnForm2b_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();
            f2b.Text = "Aperta Form Dinamica";
            f2b.Show();
        }
    }
}
