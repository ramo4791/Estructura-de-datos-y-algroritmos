using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaE
{
    class nodo
    {
        private int año;
        private string cargo;
        private string instancia;
        private string materia;
        private int cant_v;
        private int cant_m;
        private nodo siguiente;

        public int Año { get => año; set => año = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Instancia { get => instancia; set => instancia = value; }
        public string Materia { get => materia; set => materia = value; }
        public int Cant_v { get => cant_v; set => cant_v = value; }
        public int Cant_m { get => cant_m; set => cant_m = value; }
        internal nodo Siguiente { get => siguiente; set => siguiente = value; }

        public nodo()
        {

        }

        //public void set_dato(int xn)
        //{
        //    dato = xn;
        //}

        //public int get_dato ()
        //{
        //    return dato;
        //}

        //public void set_sig (nodo xs)
        //{
        //    Siguiente = xs;
        //}

        //public nodo get_sig ()
        //{
        //    return Siguiente;
        //}
    }
}

        


 


