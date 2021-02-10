using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_014_EsDictionary
{
    public partial class Form1 : Form
    {
        /*struct Item
        {
            public string key;
            public string value;
        }*/
        Dictionary<string, string> dizionario = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            //Item i;
            if (!(String.IsNullOrWhiteSpace(txtKey.Text) || String.IsNullOrWhiteSpace(txtValue.Text)))
            {
                //i.key = txtKey.Text;
                //i.value = txtValue.Text;
                //dizionario.Add(i.key,i.value);
                dizionario.Add(txtKey.Text, txtValue.Text);
                MessageBox.Show("Elemento aggiunto");
                foreach (var textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Inserire i valori correttamente");
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lblElementi.Text = "N Elementi: " + dizionario.Count().ToString();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string valoreCercare = txtCercare.Text;
            try
            {
                string elemento = dizionario[valoreCercare];
                MessageBox.Show(elemento, valoreCercare);
            }
            catch (Exception)//genera eccezione se non esiste chiave nel dizionario
            {
                MessageBox.Show("Nessuna corrispondenza trovata");
            }
        }
    }
}
