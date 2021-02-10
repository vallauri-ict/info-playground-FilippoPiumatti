using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_Interfaces
{
    class MyComponent:IDispAggiuntivo
    {
        private int _id;
        private bool _status;
        public int id { get => _id; set => _id = value; }
        public bool status => _status;
        public void connetti(string s)
        {
            _status = true;
            System.Windows.Forms.MessageBox.Show("connesso a "+s);
            id++;
        }
        public void disconnetti(string s)
        {
            _status = false;
            System.Windows.Forms.MessageBox.Show("disconnesso da: "+s);
        }
        public void stato()
        {
            if (status)
            {
                System.Windows.Forms.MessageBox.Show("Attualmente connesso"+id);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("attualmente disconnesso"+id);
            }
        }
    }
}
