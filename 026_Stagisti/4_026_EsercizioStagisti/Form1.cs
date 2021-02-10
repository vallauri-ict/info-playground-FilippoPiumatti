using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_026_EsercizioStagisti
{
    public partial class Form1 : Form
    {
        ClsElenco elencoStudenti;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elencoStudenti = new ClsElenco();
            
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            ClsAlunno alunno;
            if (numOre.Value>0)
            {
                alunno = new ClsStagista(txtNome.Text, txtCognome.Text, txtCitta.Text, int.Parse(cmbClasse.SelectedItem.ToString()), cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedItem.ToString(), cmbAzienda.SelectedItem.ToString(), numOre.Value.ToString());
            }
            else
            {
                alunno = new ClsAlunno(txtNome.Text, txtCognome.Text, txtCitta.Text, int.Parse(cmbClasse.SelectedItem.ToString()), cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedItem.ToString());
            }
            elencoStudenti.Inserisci(alunno);
            elencoStudenti.VisualizzaDgv(dgvStagisti);
            PulisciCampi();
        }

        private void PulisciCampi()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                else if(item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
            }
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string azienda = cmbAzienda.SelectedItem.ToString();
            int ore = elencoStudenti.OreAziende(azienda);
            if (ore!=0)
            {
                MessageBox.Show($"Gli stagisti hanno effettuato {ore} in {azienda}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Gli stagisti non hanno effettuato ore in {azienda}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (numPosElimina.Text == "")
                {
                    elencoStudenti.Cancella();
                }
                else
                {
                    elencoStudenti.Cancella1(Convert.ToInt32(numPosElimina.Text));
                }
                MessageBox.Show("cancellazione effettuata!");
                elencoStudenti.VisualizzaDgv(dgvStagisti);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);;
            }

        }
    }
}
