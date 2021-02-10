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
    public partial class formMain : Form
    {
        public static ToolStripStatusLabel lbl=new ToolStripStatusLabel();
        public static string datiForm="";
        public FormFiglia1 ff1;

        public formMain()
        {
            InitializeComponent();
            lbl = toolStripStatusLabel1;
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEsci fe = new FormEsci();
            if (fe.ShowDialog()==DialogResult.OK)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Operazione annullata");
            }
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point startPoint = new Point(0, 100);
            foreach (var item in this.MdiChildren)
            {
                startPoint.X += item.Width + 10;
            }
            ff1 = new FormFiglia1();
            ff1.MdiParent = this;
            ff1.Width = 300;
            ff1.Height = 300;
            ff1.StartPosition = FormStartPosition.Manual;
            ff1.Location = startPoint;
            ff1.Show();
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formMain.datiForm == "")
            {
                FormModale fm = new FormModale();
                fm.ShowDialog();
            }
            else
            {
                Point startPoint = new Point(0, 100);
                foreach (var item in this.MdiChildren)
                {
                    startPoint.X += item.Width + 10;
                }
                FormFiglia2 ff = new FormFiglia2();
                ff.MdiParent = this;
                ff.Width = 300;
                ff.Height = 300;
                ff.StartPosition = FormStartPosition.Manual;
                ff.Location = startPoint;
                ff.Show();
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModalInfo fi = new FormModalInfo();
            fi.ShowDialog();
        }
    }
}
