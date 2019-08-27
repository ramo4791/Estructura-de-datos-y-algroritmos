using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    class nodo
    {
        private int dato;
        private nodo siguiente;

        public nodo()
        {

        }

        public void set_dato(int xn)
        {
            dato = xn;
        }

        public int get_dato ()
        {
            return dato;
        }

        public void set_sig (nodo xs)
        {
            siguiente = xs;
        }

        public nodo get_sig ()
        {
            return siguiente;
        }
    }
}

        


 


