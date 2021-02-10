using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_025_MondoAnimale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tonno tonno = new Tonno("Palmera");
            tonno.mostra();
        }

        private void btnCavallo_Click(object sender, EventArgs e)
        {
            Cavallo cavallo = new Cavallo("Furia del west");
            cavallo.mostra();
        }

        private void btnUomo_Click(object sender, EventArgs e)
        {
            Uomo uomo = new Uomo("Johnny");
            uomo.mostra();
        }

        private void btnGabbiano_Click(object sender, EventArgs e)
        {
            Gabbiano gabbiano = new Gabbiano("Gabbiano");
            gabbiano.mostra();
        }

        private void btnPinguino_Click(object sender, EventArgs e)
        {
            Pinguino pinguino = new Pinguino("Tweety");
            pinguino.mostra();
        }

        private void btnCorvo_Click(object sender, EventArgs e)
        {
            Corvo corvo = new Corvo("Il corvo dell'uva");
            corvo.mostra();
        }
    }
}
