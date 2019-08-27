using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    class pilalista
    {
        private int cant;
        private nodo tope;

        public pilalista ()
        {
            cant = 0;
            tope = null;
        }
        public bool pila_vacia ()
        {
            return (cant == 0);
        }

        public int insertar_lista (int xdato)
        {
            nodo aux = new nodo();

            aux.set_dato(xdato);
            aux.set_sig(tope);
            tope = aux;
            cant++;
            return aux.get_dato();
        }

        public int suprimir_lista ()
        {
            nodo aux = new nodo();
            int x=0;
            if (pila_vacia())
                Console.WriteLine("Pila enlazada Vacia");
            else
            {
                aux = tope;
                x = tope.get_dato();
                tope = tope.get_sig();
                cant--;
            }
            return x;
        }

        public void mostrar_lista()
        {
            

            if (pila_vacia())
                Console.WriteLine("La pila enlazada esta vacia");
            else
            {
                nodo aux = tope;
                Console.WriteLine("Elementos el la pila ");
                while (aux!=null)
                {
                    Console.WriteLine(" * " + aux.get_dato());
                    aux = aux.get_sig();
                }
            }
        }
    }
}


            


