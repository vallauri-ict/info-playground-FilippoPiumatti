using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_010_ClasseIndexata
{
    public partial class formMain : Form
    {
        MyIndexClass indexVect;
        public formMain()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            if(!Int32.TryParse(txtElementi.Text,out int valore))
            {
                MessageBox.Show("Inserire un valore numerico valido");
            }
            else
            {
                indexVect = new MyIndexClass(Convert.ToInt32(txtElementi.Text));
                for (int i = 0; i < Convert.ToInt32(txtElementi.Text); i++)
                {
                    indexVect[i] = i.ToString();
                }
                MessageBox.Show("Oggetto creato correttamente");
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < indexVect.length(); i++)
            {
                s += indexVect[i] + " - ";//vado a visualizzare item [i] dell'oggetto
            }
            MessageBox.Show("Elementi: " + s);
        }
    }
}
