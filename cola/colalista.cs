using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cola
{
    class colalista
    {
        private int cant;
        private nodo pr;
        private nodo ult;

        public colalista()
        {
            cant = 0;
            pr = null;
            ult = null;
        }

        public bool colal_vacia()
        {
            if (cant == 0)
                return true;
            else
                return false;
        }

        public void insertar_colal(int xn)
        {
            nodo aux = new nodo();
            aux.set_dato(xn);
            aux.set_sig(null);

            if (ult == null)
                pr = aux;
            else
                ult.set_sig(aux);

            ult = aux;
            cant++;
        }

        public int suprimir_colal()
        {
            int x=0;
            if (colal_vacia())
            {
                Console.WriteLine("La cola esta vacia");
            }
            else
            {
                x = pr.get_dato();
                pr = pr.get_sig();
                if (cant == 1)
                    ult = null;
                cant--;

            }

            return x;
        }

        public void recorrer_colal()
        {
            if (colal_vacia())
                Console.WriteLine("La cola enlazada esta vacia");
            else
            {
                nodo aux = pr;
                Console.WriteLine("Elementos el la cola ");
                while (aux != null)
                {
                    Console.WriteLine(" * " + aux.get_dato());
                    aux = aux.get_sig();
                }
            }
        }
    }
}
