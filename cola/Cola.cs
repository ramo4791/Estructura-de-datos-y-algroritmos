using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cola
{
    class Cola
    {
        private int max;
        private int pr;
        private int ult;
        private int cant;
        private int[] elem;

        public Cola(int xmax)
        {
            pr = 0;
            ult = 0;
            cant = 0;
            max = xmax;
            elem = new int[max];
        }

        public bool vacia()
        {
            if (cant == 0)
                return true;
            else
                return false;
        }

        public void insertar (int x)
        {
            if (cant < max)
            {
                ult = (ult+1) % max;//tocar solo el ultimo
                elem[ult] = x;               
                cant++;
            }
            else Console.WriteLine("Cola llena , no se pudo insertar {0}",x);
        }

        public int suprimir ()
        {
            int x;
            if (vacia())
            {
                Console.WriteLine("Pila vacia");
                return 0;
            }
            else
            {
                x = elem[pr];
                pr = (pr + 1) % max;
                cant--;
                return x;
            }
        }

        public void recorrer ()
        {
            int xprim;
            xprim = pr;
            Console.WriteLine("Elementos de la cola");
            for (int i= 0;i<cant;i++)
            {
                Console.WriteLine("{0}", elem[xprim]);
                xprim = (xprim + 1) % max;
            }
        }
    }
}
