using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Ejer01
{
    class nodo
    {
        private int dato;
        private nodo izq;
        private nodo der;

        public nodo (int x)
        {
            dato = x;
            izq = null;
            der = null;
        }

        public void setDato (int x)
        {
            dato = x;
        }
        public int getDato()
        {
            return dato;
        }

        public void setIzq(nodo xn)
        {
            izq = xn;
        }
        public nodo getIzq()
        {
            return izq;
        }
        public void setDer(nodo xn)
        {
            der = xn;
        }
        public nodo getDer ()
        {
            return der;
        }
        //public int Dato { get => dato; set => dato = value; }
        //internal nodo Izq { get => izq; set => izq = value; }
        //internal nodo Der { get => der; set => der = value; }
    }   
}
