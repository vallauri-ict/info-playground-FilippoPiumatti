using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_020_PersoneStudenti
{
    public partial class Form1 : Form
    {
        List<Studente> lstStudents = new List<Studente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAggiungiStudente_Click(object sender, EventArgs e)
        {
            Studente stud = new Studente();
            try
            {
                stud.SetAttributes(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(NumEta.Value));
                lstStudents.Add(stud);
                listViewMain.Items.Add(stud.GetCognome());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void listViewMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cognome = listViewMain.SelectedItems[0].Text;
            Studente aus = new Studente();
            aus = lstStudents.Find(bf => bf.GetCognome()==cognome);
            //attivo disattivo btn media
            BtnVisualizzaMedia.Enabled = aus.GetNumeroVoti() > 0;
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnVisualizzaMedia.Enabled = false;
        }

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            BtnVisualizzaMedia.Enabled = true;
            //aggiungo voto a primo studente selezionato
            string cognome = listViewMain.SelectedItems[0].Text;
            Studente stud = lstStudents.Find(bf => bf.GetCognome() == cognome);//cosi posos modificare direttamente studente
            stud.AggiungiVoto(Convert.ToInt32(numVoti.Value));
        }

        private void BtnVisualizzaMedia_Click(object sender, EventArgs e)
        {
            string cognome = listViewMain.SelectedItems[0].Text;
            Studente aus = lstStudents.Find(bf => bf.GetCognome() == cognome);//find ritorna oggetto
            try
            {
                MessageBox.Show("Lo studente " + aus.GetNome() + " " + aus.GetCognome() + " ha media: " + aus.Media().ToString("0.00"));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
