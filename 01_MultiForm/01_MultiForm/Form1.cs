using System;
using System.Windows.Forms;

namespace _01_MultiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            //apertura form senza parametro
            Form2 f2 = new Form2();//new istanza l'oggetto
            f2.Text = "Form senza parametro";
            f2.Show();

            //apertura form con parametro
            Form2 f2p = new Form2(10);//new istanza l'oggetto
            f2p.Text = "Form con parametro";
            f2p.Show();
        }

        private void btnForm2B_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();//creo dinamicamente, senza aggiungere prima classe con classe di default di C#
            f2b.Text = "Form dinamica aperta";
            f2b.Show();
        }
            
        private void btnPassaTxt_Click(object sender, EventArgs e)
        {
            Form2 f2p = new Form2(txtPassata);//new istanza l'oggetto
            f2p.Text = "Form con parametro";
            f2p.Show();
        }

        private void btnApriFormModale_Click(object sender, EventArgs e)
        {
            FormModale fm = new FormModale();
            //MessageBox.Show(fm.ShowDialog()==DialogResult.OK? "Premuto OK": "Premuto Annulla");
            if (fm.ShowDialog() == DialogResult.OK)//su ShowDialog() la Form si apre e resta in attesa
            {
                txtNomeFormMain.Text = fm.nome;
                txtEtaFormMain.Text = fm.eta;
                MessageBox.Show("Premuto OK");
            }
            else
            {
                txtNomeFormMain.Text = "";
                txtEtaFormMain.Text = "";
                MessageBox.Show("Premuto Annulla");
            }
        }
    }
}
