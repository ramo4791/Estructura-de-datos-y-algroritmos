using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer05
{
    class piladoble
    {
        private int tope1;
        private int tope2;
        private int cant;
        private int[] elem;


        public piladoble (int xcant)
        {
            cant = xcant;
            elem = new int[cant];
            tope1 = -1;
            tope2 = cant;
        }
        
        public bool pila_llena ()
        {
            if (tope1==tope2-1)
                return true;
            else
                return false;
        }

        public bool pila1_vacia ()
        {
            if (tope1 == -1)
                return true;
            else
                return false;
        }
        public bool pila2_vacia()
        {
            if (tope2 == cant)
                return true;
            else
                return false;
        }

        public void insertar1(int xn) //push
        {
            if (pila_llena()==true)
            {
                Console.WriteLine("\n La pila esta llena ");
            }
            else
            {
                tope1++;
                elem[tope1] = xn;
                Console.WriteLine("elemento insertado " + elem[tope1]);
            }
        }

        public void insertar2(int xn) //push
        {
            if (pila_llena() == true)
            {
                Console.WriteLine("\n La pila esta llena ");
            }
            else
            {
                tope2--;
                elem[tope2] = xn;
                Console.WriteLine("elemento insertado " + elem[tope2]);
            }
        }
        public int suprimir1 () //pop
        {
            int n = 0;
            if (pila1_vacia())
                Console.WriteLine("La pila esta vacia");     
            else
            {
                n = elem[tope1];
                tope1--;
            }
            return n;
        }
        public int suprimir2() //pop
        {
            int n = 0;
            if (pila2_vacia())
                Console.WriteLine("La pila esta vacia");
            else
            {
                n = elem[tope2];
                tope2++;
            }
            return n;
        }

    

        public void mostrar1 ()
        {
            if (!pila1_vacia())
            {
                Console.WriteLine("Elementos de Pila 1: ");
                for (int i = tope1; i >= 0; i--)
                    Console.WriteLine(" - " + elem[i]);
            }
            else
                Console.WriteLine("Pila 1 vacia");
        }

        public void mostrar2()
        {
            if (!pila2_vacia())
            {
                Console.WriteLine("Elementos Pila 2: ");
                for (int i = tope2; i <cant; i++)
                    Console.WriteLine(" - " + elem[i]);
            }
            else
                Console.WriteLine("Pila 2 vacia");
        }

    }
}
