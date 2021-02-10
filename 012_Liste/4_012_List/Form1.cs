using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_012_List
{
    public partial class Form1 : Form
    {
        public struct Libro {
            public int ID;
            public string Titolo;
            public string Autore;

        }
        List<Libro> libri = new List<Libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Libro l;
            l.ID = Convert.ToInt32(txtID.Text);
            l.Titolo = txtTitolo.Text;
            l.Autore = txtAutore.Text;
            libri.Add(l);
            MessageBox.Show("Aggiunto correttamente");
            clear();
        }

        private void clear()
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            foreach (var item in libri)
            {
                MessageBox.Show(item.Titolo + " " + item.Autore,item.ID.ToString()) ;
            }
        }

        private void btnCreaObj_Click(object sender, EventArgs e)
        {
            try
            {
                ClasseLibro cl = ClasseLibro.creaLibro(txtTitolo.Text, txtAutore.Text, Convert.ToInt32(txtID.Text));
                MessageBox.Show("Oggetto creato correttamente");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVisualizzaObj_Click(object sender, EventArgs e)
        {
            ClasseLibro.visualizzaLibri();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ClasseLibro.Find(txtRicerca.Text);
            txtRicerca.Text = "";
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            ClasseLibro.FindAll(txtRicerca.Text);
            txtRicerca.Text = "";
        }
    }
}
