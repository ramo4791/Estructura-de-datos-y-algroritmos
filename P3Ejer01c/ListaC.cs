using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Ejer01c
{
    class ListaC
    {
        private nodo[] nodos;
        private int cant_l;
        private int cant_p;
        private int disp;//cabeza pila
        private int cab;//cabeza de lista
        private int tam;


        public ListaC(int xtam)
        {
            cab = -1;
            tam = xtam;
            nodos = new nodo[tam];      
            disp = -1;
            cant_l = 0;
            cant_p = 0;
            //inicializa pila espacios libres
            for (int i = 0; i<tam; i++)
            {
                insertar_p(i);
            }
        }

        public bool pila_llena()
        {
            if (cant_p==tam)
                return true;
            else
                return false;
        }

        public bool pila_vacia()
        {
            if (cant_p == 0)
                return true;
            else
                return false;
        }

        public bool insertar_p(int xn) //push
        {
            if (pila_llena() == true)
            {
                Console.WriteLine("\n La pila esta llena ");
                return false;
            }
            else
            {
                nodo aux = new nodo();
                aux.set_dato(xn);
                aux.set_sig(disp);
                nodos[xn] = aux;
                disp = xn;
                cant_p++;
                return true;
            }
        }

        public int suprimir_p() //pop
        {
            int x;
            
            x = nodos[disp].get_dato();
            disp = nodos[disp].get_sig();
            cant_p--;   
            return x;
        }

        public void mostrar_p()
        {
            if (!pila_vacia())
            {
                int xcab = disp;
                Console.WriteLine("Elementos Pila: ");
                while(xcab!=-1)
                {
                    Console.WriteLine(" - " + nodos[xcab].get_dato());
                    xcab = nodos[xcab].get_sig();
                }
            }
            else
                Console.WriteLine("Pila vacia");
        }


        public bool insertar_c(int x, int p)
        {

            int ant, xcab;
            int aux;
            int i = 1;
            if (pila_vacia())
                return false;//sale si no hay espacio en memoria
            aux = suprimir_p();

            nodos[aux].set_dato(x);

            if (p >= 1 && p <= cant_l + 1) // si la posicion es correcta se inserta
            {
                if ((cant_l == 0) || (p == 1))//primer caso lista vacia o el el primero
                {
                    nodos[aux].set_sig(cab); 
                    cab = aux;
                    cant_l++;
                }
                else
                {
                    xcab = cab;
                    ant = cab;//obliga a inicializar anterior

                    while (i<p)
                    {
                        ant = xcab;
                        xcab = nodos[xcab].get_sig(); 
                        i++;
                    }
                    nodos[ant].set_sig(aux);
                    nodos[aux].set_sig(xcab);
                    cant_l++;
                }
                return true;
            }
            else
                return false;
        }

        public bool suprimir_c(ref int x, int p)
        {
            int ant, xcab;
            int i = 1;
            int aux;
            if (p >= 1 && p <= cant_l && !vacia_lc())//valido posicion y que no este vacia
            {
                if (p == 1)
                {
                    //x = cab.get_dato();
                    x = nodos[cab].get_dato();
                    //cab = cab.get_sig();
                    aux = cab;
                    cab = nodos[cab].get_sig();
                    insertar_p(aux);
                }
                else
                {
                    xcab = cab;
                    ant = cab;
                    while (i < p)
                    {
                        ant = xcab;
                        //xcab = xcab.get_sig();
                        xcab = nodos[xcab].get_sig();
                        i++;
                    }
                    //x = xcab.get_dato();
                    x = nodos[xcab].get_dato();
                    aux = xcab;
                    //ant.set_sig(xcab.get_sig());//hace el enlace en para eliminar elemento;
                    nodos[ant].set_sig(nodos[xcab].get_sig());
                    insertar_p(aux);
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
                    Console.WriteLine(" - " + nodos[xcab].get_dato());
                    xcab = nodos[xcab].get_sig();
                }
            }
            else
                Console.WriteLine("Lista VACIA");
        }


    }
}
