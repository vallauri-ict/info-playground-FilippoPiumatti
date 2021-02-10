using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_019_Ereditarietà03Parametri
{
    public class Mostro
    {
        public string nome;
        public Mostro()

        : this("Mostro")

        {
        }
        public Mostro(string nome)
        {
            this.nome = nome;
        }
        public void Rivela()
        {
            System.Windows.Forms.MessageBox.Show(nome);
        }
    }
}
