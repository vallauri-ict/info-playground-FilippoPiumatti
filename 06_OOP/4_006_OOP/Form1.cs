using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_006_OOP
{
    public partial class Form1 : Form
    {
        //creo oggetto relavito alla classe
        Rectangle r = new Rectangle();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaRect_Click(object sender, EventArgs e)
        {
            /*r.side1 = Convert.ToInt32(txtBase.Text);
            r.side2 = Convert.ToInt32(txtAltezza.Text);
            Rectangle t;
            t = r;//t punta alla stessa area di memoria di r
            MessageBox.Show("r: Base: "+r.side1+" - Altezza: "+r.side2,"r");
            MessageBox.Show("t: Base: " + t.side1 + " - Altezza: " + t.side2,"t");
            //modificando t, modifico area di memoria relativa anche ad r e modifico anche quest'ultimo
            t.side1 = 10;
            MessageBox.Show("r dopo modifiche: " + r.side1 + " - Altezza: " + r.side2, "r modificato");*/

            r.colore = Color.White;
            MessageBox.Show(r.getSide());
            Rectangle r1 = new Rectangle(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text));
            MessageBox.Show(r1.getSide());

            r = new Rectangle(4);
            r.colore = Color.White;

        }

        private void btnCreaFattura_Click(object sender, EventArgs e)
        {
            Fattura f = new Fattura();
            MessageBox.Show("Fattura creata!");
        }

        private void btnNFattura_Click(object sender, EventArgs e)
        {
            Fattura.visualizza();
        }

        private void btnClasseStatica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pi greco: "+MiaMath.pi+"\n3*4 ="+MiaMath.prodotto(3,4));
        }
    }
}
