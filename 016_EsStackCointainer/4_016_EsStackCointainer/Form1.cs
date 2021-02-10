using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_016_EsStackContainer
{
    public partial class Form1 : Form
    {
        Stack<Container> stackContainer = new Stack<Container>();
        struct Container
        {
            public string code;
            public int weight;
            public int tare;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCarica.BackColor = Color.Green;
            btnScarica.BackColor = Color.Red;
            btnScarica.Enabled = false;//inizializzo bloccato
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            Container cn;
            if (String.IsNullOrWhiteSpace(txtCodice.Text))
            {
                MessageBox.Show("Inserire un codice valido");
            }
            else
            {
                if (numPeso.Value<numTara.Value)
                {
                    MessageBox.Show("Il peso totale non può essere inferiore della tara!");
                }
                else if (numTara.Value==0)//contro alla numPeso indirettamente con la if sopra
                {
                    MessageBox.Show("Inserire una tara valida");
                }
                else
                {
                    cn.code = txtCodice.Text;
                    cn.weight =Convert.ToInt32(numPeso.Value);
                    cn.tare = Convert.ToInt32(numTara.Value);
                    stackContainer.Push(cn);
                    MessageBox.Show("Container inserito correttamente");
                    btnScarica.Enabled = true;
                    foreach (var item in this.Controls.OfType<TextBox>())
                    {
                        item.Text="";
                    }
                    foreach (var item in this.Controls.OfType<NumericUpDown>())
                    {
                        item.Value = 0;
                    }
                }
            }
        }

        private void btnScarica_Click(object sender, EventArgs e)
        {
            //al posto di dare errore di stack vuoto blocco il bottone
            Container aus;
            aus = stackContainer.Pop();
            MessageBox.Show(aus.code+"\n"+"Peso: "+aus.weight.ToString()+" - Tara:"+aus.tare.ToString()+"\nPeso carico: "+(aus.weight-aus.tare),aus.code);
            if (stackContainer.Count==0)
            {
                btnScarica.Enabled = false;
            }
        }
    }
}
