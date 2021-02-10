using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _027_Interfaces
{
    public partial class Form1 : Form
    {
        MyComponent con;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnetti_Click(object sender, EventArgs e)
        {
            con.connetti("componente 1");
        }

        private void btnDisconnetti_Click(object sender, EventArgs e)
        {
            con.disconnetti("componente 1");
        }

        private void btnStato_Click(object sender, EventArgs e)
        {
            con.stato();
        }
    }
}
