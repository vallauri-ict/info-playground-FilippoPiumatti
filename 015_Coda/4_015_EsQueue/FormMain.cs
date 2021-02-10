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
    public partial class FormMain : Form
    {
        //volendo temp random 
        /*
        const int MINTEMP= 35;
        const int MAXTEMP= 41;
        */
        Random rnd = new Random();
        public static Dictionary<string, Queue<Paziente>> code = new Dictionary<string, Queue<Paziente>>();
        public struct Paziente
        {
            public string nome;
            public int eta;
            public string colore;
            public int temp;
        }
        public Queue<Paziente> Rosso = new Queue<Paziente>();
        public Queue<Paziente> Giallo = new Queue<Paziente>();
        public Queue<Paziente> Verde = new Queue<Paziente>();
        public Queue<Paziente> Bianco = new Queue<Paziente>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormMedico fm = new FormMedico();
            fm.Show();
            code.Add("rosso", Rosso);
            code.Add("giallo", Giallo);
            code.Add("verde", Verde);
            code.Add("bianco", Bianco);
        }

        private void btnInserisciPaziente_Click(object sender, EventArgs e)
        {
            bool error = false;
            foreach (var item in Controls.OfType<TextBox>())
            {
                if (String.IsNullOrWhiteSpace(item.Text))
                {
                    error = true;
                }
            }
            if (!error)
            {
                if (cmbColore.SelectedIndex==-1)
                {
                    error = true;
                }
                else if (numTemp.Value<34&&numTemp.Value>43)
                {
                    error = true;
                }
                else
                {
                    Paziente p;
                    p.nome = txtCognome.Text + " " + txtNome.Text;
                    p.eta = Convert.ToInt32(numEta.Value);
                    p.colore = cmbColore.SelectedItem.ToString();
                    //p.temp = rnd.Next(MINTEMP, MAXTEMP);
                    p.temp = Convert.ToInt32(numTemp.Value);
                    code[p.colore.ToLower()].Enqueue(p);
                    MessageBox.Show("Paziente inserito");
                    foreach (var item in Controls.OfType<TextBox>())
                    {
                        item.Text = "";
                    }
                    foreach (var item in Controls.OfType<NumericUpDown>())
                    {
                        item.Value = 0;
                    }
                    cmbColore.SelectedIndex = -1;
                }  
            }
            if (error)
            {
                MessageBox.Show("Inserire correttamente i dati");
            }
        }

        private void btnMassima_Click(object sender, EventArgs e)
        {
            //potrei cercare modo con findall
            int max=-1;
            foreach (var item in code)
            {
                foreach (var paz in item.Value)
                {
                    if (paz.temp>max)
                    {
                        max = paz.temp;
                    }
                }
            }
            MessageBox.Show("Temperatura massima giornaliera: "+max.ToString());
        }

        private void btnMinima_Click(object sender, EventArgs e)
        {
            int min = 50;
            foreach (var item in code)
            {
                foreach (var paz in item.Value)
                {
                    if (paz.temp < min)
                    {
                        min = paz.temp;
                    }
                }
            }
            MessageBox.Show("Temperatura minima giornaliera:" +min.ToString());
        }
    }
}
