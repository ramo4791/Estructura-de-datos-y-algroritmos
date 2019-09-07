using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Ejer03
{
    class nodo
    {
        private int dato;
        private string nombre;
        private float superficie;
        private nodo siguiente;

        public nodo()
        {

        }

        public void set_nombre(int xn)
        {
            dato = xn;
        }

        public string get_nombre()
        {
            return nombre;
        }
        public void set_superficie(int xn)
        {
            dato = xn;
        }

        public float get_superficie()
        {
            return superficie;
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

        


 


