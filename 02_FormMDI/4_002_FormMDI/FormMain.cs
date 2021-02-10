using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_002_FormMDI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnApriF1_Click(object sender, EventArgs e)
        {
            FormFiglia1 f = new FormFiglia1();
            f.Text = "Form Figlia 1";
            f.MdiParent = this;//this si riferisce alla form attuale
            f.Size = new Size(210, 180);//utilizzo oggetto Size
            f.StartPosition = FormStartPosition.Manual;//imposto proprietà di posizionamento tramite codice
            f.Location = new Point(0,20);//utilizzo oggetto point
            f.Show();
        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            FormFiglia2 f = new FormFiglia2();
            f.Text = "Form Figlia 2";
            f.MdiParent = this;//this si riferisce alla form attuale
            f.Size = new Size(210, 180);//utilizzo oggetto Size
            f.StartPosition = FormStartPosition.Manual;//imposto proprietà di posizionamento tramite codice
            f.Location = new Point(215, 20);//utilizzo oggetto point
            f.Show();
        }

        private void btnFAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte "+this.MdiChildren.Length+" finestre");//MdiChildren è collezione che contiene le Form Mdi figlie del genitore indicato
            foreach (Form f in this.MdiChildren)//scorro le Form preseni nella collezione MdiChildren
            {
                MessageBox.Show("Finestra "+f.Text+" aperta");
            }
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto Apri1";
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto Apri2";
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModalEsci f = new FormModalEsci();
            f.Text = "Uscire";
            if (f.ShowDialog()==DialogResult.Yes)
            {
                Close();
            }
        }

    }
}
