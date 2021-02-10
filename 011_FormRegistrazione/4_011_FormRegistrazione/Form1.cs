using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_011_FormRegistrazione
{
    public partial class Form1 : Form
    {
        const string fileName = "utenti.txt";
        public Form1()
        {
            InitializeComponent();
        }

        //potrei ottimizzare inserendo una crittografia della password oppure richiamando il controlla txt su una determinata txt quando perde il focus, mettere dgv dove visualizzare contenuto del file
        private void btnRegistra_Click(object sender, EventArgs e)
        {
            bool valido = true;

            //COGNOME
            Regex regCognome = new Regex(@"^[A-Z]{1}[a-z]+$");//@ per evitare di fare doppio backslash, + uno o più 
            controllaTxt(txtCognome, regCognome,ref valido);
            //NOME
            Regex regNome = regCognome;
            controllaTxt(txtNome, regNome, ref valido);
            //Indirizzo
            Regex regIndirizzo = new Regex(@"^[A-Z]{1}[A-Za-z]+\s+[A-Za-z]+\s+[\d,A-Z,a-z]+$");
            controllaTxt(txtIndirizzo, regIndirizzo, ref valido);
            //citta
            Regex regCitta = new Regex(@"^[A-Z]{1}[a-z]+$");
            controllaTxt(txtCitta, regCitta, ref valido);
            //CAP
            Regex regCap = new Regex(@"^\d{5}$");
            controllaTxt(txtCap, regCap, ref valido);
            //mail
            Regex regMail = new Regex(@"^[A-Za-z,\-,_,.,\d]+@{1}[A-Za-z,\d]+\.[A-Za-z]{2,4}$");
            controllaTxt(txtMail, regMail, ref valido);

            Regex regUser = new Regex(@"^[A-Za-z,\d,\-,_,.]+$");
            controllaTxt(txtUsername, regUser, ref valido);

            Regex regPassword = new Regex(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z]).{8,20}$");
            controllaTxt(txtPassword, regPassword, ref valido);
            //io farei tutti i controlli, per evitare di creare oggeetti inutili. se alla fine tutto a posto creo oggetto e inserisco
            if (valido)
            {
                try
                {
                    Utente user = Utente.creaUtente(txtCognome.Text, txtNome.Text, txtIndirizzo.Text, txtCitta.Text, txtCap.Text, txtMail.Text, txtUsername.Text, txtPassword.Text);
                    InsiemeUtenti.AggiungiUtente(user, fileName);
                    MessageBox.Show("Utente creato correttamente");
                    foreach (var item in this.Controls.OfType<TextBox>())
                    {
                        item.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtUsername.BackColor = Color.Red;
                }
            }


            //TODO: altri caratteri

            /* mail:
             inizia con dei caratteri o '.','_','-'
             presenza di '@'
            alcuni caratteri poi '.' poi da 2 a 4 caratteri
             */
        }

        private void controllaTxt(TextBox txt, Regex reg, ref bool valido)
        {
            if (String.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show("Dato mancante in "+txt.Name);
                valido = false;
                txt.BackColor = (Color.Red);
            }
            else if (!reg.IsMatch(txt.Text))
            {
                MessageBox.Show("Dato inserito non valido in " + txt.Name);
                valido = false;
                txt.BackColor = (Color.Red);
            }
            else
            {
                txt.BackColor = Color.White;
            }
        }


    }
}
