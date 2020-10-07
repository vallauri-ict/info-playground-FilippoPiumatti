using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_FormMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriF1_Click(object sender, EventArgs e)
        {
            figlia1 f = new figlia1();
            f.Text = "figlia 1";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(50, 0);
            f.Show();
        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            figlia2 f = new figlia2();
            f.Text = "figlia 2";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(215,20);
            f.Show();
        }

        private void btnAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono State Aperte " + this.MdiChildren.Length + " finestre");
            foreach (Form f in this.MdiChildren)
            {
                MessageBox.Show("finestra " + f.Text + " Aperta");
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalEsci f = new ModalEsci();
            f.Text = "uscire?";
            if (f.ShowDialog()==DialogResult.OK)
            {
                Close();
            }
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatuslbl.Text = "premuto apri 1";
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatuslbl.Text = "premuto apri 2";
        }
    }
    }


