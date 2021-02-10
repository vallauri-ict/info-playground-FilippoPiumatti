using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _028_usoInterfacciaIcomparalble
{
    public partial class Form1 : Form
    {
        Persona[] vect = { new Persona("luca", "bonelli", "fossano"),new Persona("antonio","ariaudo","alba"),new Persona("samuele","setrfirca","cuneo")};
                            
        public Form1()
        {
            InitializeComponent();
            showInterface();
        }
        public void showInterface()
        {
            string s = "";
            foreach (var item in vect)
            {
                s = item.ToString() + "\n";
                MessageBox.Show(s);
            }
           
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            Array.Sort(vect);
            showInterface();
        }
    }
}
