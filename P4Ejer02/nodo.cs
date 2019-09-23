using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Ejer02
{
    class nodo
    {
        private string dato;
        private nodo izq;
        private nodo der;

        public nodo (string x)
        {
            dato = x;
            izq = null;
            der = null;
        }

        public void setDato (string x)
        {
            dato = x;
        }
        public string getDato()
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
