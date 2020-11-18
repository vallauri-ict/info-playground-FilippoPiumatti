using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_project
{
    public partial class Form1 : Form
    {
        public struct libro
        {
            public string titolo;
            public string autore;
        }
        public int i = 0;
        Dictionary<int, libro> Dizionario = new Dictionary<int, libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            libro l;
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;
            Dizionario.Add(i++, l);
            MessageBox.Show("libro inserito correttamente");
            
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
           /* foreach (int key in Dizionario.Keys)
            {
                MessageBox.Show(Convert.ToString(key));
            }*/
            foreach (libro l in Dizionario.Values)
            {
                MessageBox.Show(l.titolo + " " + l.autore);
            }
        }
    }
}
