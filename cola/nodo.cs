using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cola
{
    class nodo
    {
        private int dato;
        private nodo siguiente;
        DateTime hora;

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
        public void set_hora (DateTime h)
        {
            hora = h;
        }

        public DateTime get_hora()
        {
            return hora;
        }
    }
}

        


 


