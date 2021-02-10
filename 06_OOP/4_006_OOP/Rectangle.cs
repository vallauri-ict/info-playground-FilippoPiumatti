using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_006_OOP
{
    class Rectangle
    {
        private int side1, side2;//se private non accessibile se non dall'interno della classe o con proprietà
        public Color colore;
        public string descrizione;
        public Rectangle():this(1)//genero costruttore che verrà richiamato, assegnando side 1 e side2
        {
            descrizione = "Sono un rettangolo";
            /*side1 = 1;
            side2 = 1;*/
        }
        //OVERLOAD dei costruttori in base ai parametri

        public Rectangle(int l) : this(l, l)
        {

        }


        public Rectangle(int b, int h)//genero costruttore che verrà richiamato, assegnando side 1 e side2
        {
            side1 = b;
            side2 = h;
        }

        public string getSide()
        {
            return "Base: "+side1.ToString() + " - Altezza: " + side2.ToString();
        }
    }
}
