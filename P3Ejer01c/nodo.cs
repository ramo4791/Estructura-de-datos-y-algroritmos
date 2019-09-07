using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Ejer01c
{
    class nodo
    {
        private int dato;
        private int sig;

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

        public void set_sig (int xs)
        {
            sig = xs;
        }

        public int get_sig ()
        {
            return sig;
        }
    }
}

        


 


