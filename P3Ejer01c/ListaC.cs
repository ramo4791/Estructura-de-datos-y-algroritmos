using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Ejer01c
{
    class ListaC
    {
        private int[] item;
        private int[] sig;
        private int[] pil;
        private int cant_l;
        private int tope;
        private int tam;
        private int cab;


        public ListaC(int xtam)
        {
            cab = -1;
            tam = xtam;
            item = new int[tam];
            sig = new int[tam];
            pil = new int[tam];
            tope = tam;
            cant_l = 0;
            //inicializa pila espacios libres
            for (int i = 9; i >= 0; i--)
            {
                insertar_sig(i);
            }
        }

        public bool pila_vacia()
        {
            if (tope == tam)
                return true;
            else
                return false;
        }

        public bool pila_llena()
        {
            if (tope == 0)
                return true;
            else
                return false;
        }
        public void insertar_sig(int xn) //push
        {
            if (pila_llena() == true)
            {
                Console.WriteLine("\n La pila esta llena ");
            }
            else
            {
                tope--;
                pil[tope] = xn;
                Console.WriteLine("elemento insertado " + pil[tope]);
            }
        }
        public int suprimir_sig() //pop
        {
            int n = 0;
            if (pila_vacia())
                Console.WriteLine("La pila esta vacia");
            else
            {
                n = pil[tope];
                tope++;
            }
            return n;
        }

        public void mostrar_sig()
        {
            if (!pila_vacia())
            {
                Console.WriteLine("Elementos Pila: ");
                for (int i = tope; i < tam; i++)
                    Console.WriteLine(" - " + pil[i]);
            }
            else
                Console.WriteLine("Pila vacia");
        }

        public bool insertar_c(int x, int p)
        {
            
            int ant, xcab, aux;
            int i = 1;
            if (pila_vacia())
                return false;//sale si no hay espacio en memoria
            aux = suprimir_sig();
            item[aux] = x;

            if (p >= 1 && p <= cant_l + 1 ) // si la posicion es correcta se inserta
            {
                if ((cant_l == 0) || (p == 1))//primer caso lista vacia o el el primero
                {
                    sig[aux] = cab;
                    cab = aux;
                    cant_l++;
                }
                else
                {
                    xcab = cab;
                    ant = cab;//obliga a inicializar anterior

                    while (i < p)
                    {
                        ant = xcab;
                        xcab = sig[xcab];
                        i++;
                    }
                    //ant.set_sig(aux);
                    sig[ant] = aux;
                    //aux.set_sig(xcab);
                    sig[aux] = xcab;
                    cant_l++;
                }
                return true;
            }
            else
                return false;
        }
        public bool suprimir_lc(ref int x, int p)
        {
            int ant, xcab;
            int i = 1;
            int free;
            if (p >= 1 && p <= cant_l && !vacia_lc())//valido posicion y que no este vacia
            {
                if (p == 1)
                {
                    //x = cab.get_dato();
                    x = item[cab];
                    //cab = cab.get_sig();
                    free = cab;
                    cab = sig[cab];
                    insertar_sig(free);
                }
                else
                {
                    xcab = cab;
                    ant = cab;
                    while (i < p)
                    {
                        ant = xcab;
                        //xcab = xcab.get_sig();
                        xcab = sig[xcab];
                        i++;
                    }
                    //x = xcab.get_dato();
                    x = item[xcab];
                    free = xcab;
                    //ant.set_sig(xcab.get_sig());//hace el enlace en para eliminar elemento;
                    sig[ant] = sig[xcab];
                    insertar_sig(free);
                }
                cant_l--;
                return true;
            }
            else
                return false;

        }

     


        public bool vacia_lc()
        {
            if (cant_l == 0)
                return true;
            else
                return false;

        }

        public void mostrar_lc()
        {
            int xcab;
            xcab = cab;
            if (!vacia_lc())
            {
                Console.WriteLine("Elementos de la lista");
                while (xcab != -1)
                {
                    Console.WriteLine(" - " + item[xcab]);
                    xcab = sig[xcab];
                }
            }
            else
                Console.WriteLine("Lista VACIA");
        }


    }
}
