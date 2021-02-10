using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_024_EreditarietàCarte2
{
    public partial class Form1 : Form
    {
        MazzoCarte mazzo;//singleton sarebbe meglio
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            try
            {
                mazzo.InserisciCarta(txtValore.Text, txtSeme.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCercaCarta_Click(object sender, EventArgs e)
        {
            int pos = mazzo.DammiCarta(txtValore.Text, txtSeme.Text);
            MessageBox.Show(pos==-1?"Carta non presente":"La carta si trova in posizione: " + (pos+1));
        }

        private void btnCarta1_Click(object sender, EventArgs e)
        {
            Carte aus = mazzo.DammiCarta();
            MessageBox.Show("La carta estratta è: "+aus.Valore+" - "+aus.Seme);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mazzo = new MazzoCarte();
        }

        private void btnMescola_Click(object sender, EventArgs e)
        {
            mazzo.MescolaCarte();
        }
    }
}
