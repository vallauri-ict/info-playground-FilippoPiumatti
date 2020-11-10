using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace regex_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string[] esempiTarghe = { "Eb612Pt", "EW121Po", "ew212Rt" };
            string[] esempiPassword = { "wereeeee345", "ascfgrew223", "pptsophh538" };
            Regex targa = new Regex("(([A-Z]|[a-z]){2},{3}([A-Z]|[a-z]){2})");
            Regex passWord = new Regex("(([A-Z]|[a-z]){8},{3}([?,*,-]))");

            foreach (string item in esempiTarghe)
            {
                if (txtTarga.Text!="")
                {
                    MessageBox.Show("{0} , {1} accettato"+item,targa.IsMatch(item)? " è " : " non è ");
                }
            }
            foreach (string item in esempiPassword)
            {
                if (txtPassword.Text != "")
                {
                    MessageBox.Show("{0} , {1} accettato" + item, passWord.IsMatch(item) ? " é " : " non è ");
                }
            }
        }
    }
}
