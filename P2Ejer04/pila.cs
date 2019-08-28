using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Ejer04
{
    class pila
    {
        private int tope;
        private int cant;
        private int[] elem;

        public pila ()
        {

        }

        public pila (int xcant)
        {
            cant = xcant;
            elem = new int[cant];
            tope = -1;
        }
        
        public bool pila_llena ()
        {
            if (tope == cant - 1)
                return true;
            else
                return false;
        }

        public bool pila_vacia ()
        {
            if (tope == -1)
                return true;
            else
                return false;
        }

        public void insertar (int xn) //push
        {
            if (pila_llena()==true)
            {
                Console.WriteLine("\n La pila esta llena ");
            }
            else
            {
                tope++;
                elem[tope] = xn;
                //Console.WriteLine("elemento insertado " + elem[tope]);
            }
        }

        public int suprimir () //pop
        {
            int n = 0;
            if (pila_vacia())
                Console.WriteLine("La pila esta vacia");     
            else
            {
                n = elem[tope];
                tope--;
            }
            return n;
        }

        public int pila_tope()
        {
            return elem[tope];
        }


        public void mostrar ()
        {
            if (!pila_vacia())
            {
                Console.WriteLine("Elementos : ");
                for (int i = tope; i >= 0; i--)
                    Console.WriteLine(" - " + elem[i]);
            }
            else
                Console.WriteLine("Pila vacia");
              
        }

    }
}
