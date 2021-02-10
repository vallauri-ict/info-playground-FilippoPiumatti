using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaccaPaolo
{
    public partial class FormFiglia1 : Form
    {
        public FormFiglia1()
        {
            InitializeComponent();
        }

        private void chkPelle_CheckedChanged(object sender, EventArgs e)
        {
            cambioValori();
        }

        private void cambioValori()
        {
            if (cmbMarca.SelectedIndex != -1)
            {
                formMain.datiForm = "Hai selezionato una " + cmbMarca.SelectedItem;
                if (chkPelle.Checked)
                {
                    formMain.datiForm += " con interni in Pelle -";
                }
                if (chkStoffa.Checked)
                {
                    formMain.datiForm += " con interni in Stoffa";
                }
            }
            else
            {
                formMain.datiForm = "";
            }
        }

        private void chkStoffa_CheckedChanged(object sender, EventArgs e)
        {
            cambioValori();
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            formMain.lbl.Text = "La tua auto è una " + cmbMarca.SelectedItem;
            cambioValori();
        }
    }
}
