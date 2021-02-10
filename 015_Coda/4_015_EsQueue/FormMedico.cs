using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_015_EsQueue
{
    public partial class FormMedico : Form
    {
        public FormMedico()
        {
            InitializeComponent();
        }

        private void btnProssimoPaziente_Click(object sender, EventArgs e)
        {
            /*if (FormMain.code["rosso"].Count!=0)
            {

            }
            else if (FormMain.code["giallo"].Count != 0)
            {
                
            }
            else if (FormMain.code["verde"].Count != 0)
            {

            }
            else if (FormMain.code["bianco"].Count != 0)
            {

            }
            else
            {
                MessageBox.Show("Nessun paziente disponibile");
            }*/
            FormMain.Paziente aus= new FormMain.Paziente();
            foreach (var item in FormMain.code.Values)
            {
                if (item.Count()!=0)
                {
                    aus = item.Dequeue();
                    break;
                }
            }
            if (aus.nome==null)//non trovo pazienti
            {
                MessageBox.Show("Non sono presenti pazienti");
            }
            else
            {
                MessageBox.Show(aus.nome+": "+aus.eta+"\n"+aus.colore.ToUpper()+"\nTemperatura: "+aus.temp.ToString(),aus.nome);
            }
            
        }
    }
}
