using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaE
{
    class listap_enlazada
    {
        private int cant;
        private nodo cab;

        public listap_enlazada()
        {
            cant = 0;
            cab = null;
        }

        public bool insertar_p(int x, int p)
        {
            nodo aux,ant,xcab;
            aux = new nodo();
           // ant = new nodo();

            aux.set_dato(x);
            int i = 1;

            if (p >= 1 && p <= cant + 1)//primero valido posicion
            {
                if ((cant == 0) || (p==1))//primer caso lista vacia o el el primero
                {
                    aux.set_sig(cab);
                    cab = aux;
                    cant++;
                }
                else
                {
                    xcab = cab;
                    ant = cab;//obliga a inicializar anterior

                    while (i < p)
                    {
                        ant = xcab;
                        xcab = xcab.get_sig();
                        i++;
                    }
                    ant.set_sig(aux);
                    aux.set_sig(xcab);
                    cant++;
                }

                return true;
            }
            else
                return false;
        }
        public void insertar_o(int xa, string xc, string xi, string xm, int cv,int cm)
        {
            nodo aux, ant, xcab;

            aux = new nodo();
            aux.Año=xa;
            aux.Cargo = xc;
            aux.Instancia = xi;
            aux.Materia = xm;
            aux.Cant_v = cv;
            aux.Cant_m = cm;
         
            if ((cant == 0) || (xa <= cab.))//primer caso lista vacia o el el primero
            {
                //aux.set_sig(cab);
                aux.Siguiente = cab;
                cab = aux;
                cant++;
            }
            else
            {
                xcab = cab;
                ant = cab;//obliga a inicializar anterior

                while ((xcab!=null) && (x > xcab.get_dato()))
                {
                    ant = xcab;
                    xcab = xcab.get_sig();
                }
                ant.set_sig(aux);
                aux.set_sig(xcab);
                cant++;
            }
        }

             

        public bool suprimir (ref int x, int p )
        {
            nodo ant, xcab;
            int i = 1;

            if (p >= 1 && p <= cant && !vacia())//valido posicion y que no este vacia
            {
                if (p==1)
                {
                    x = cab.get_dato();
                    cab = cab.get_sig();
                }
                else
                {
                    xcab = cab;
                    ant = cab;
                    while(i < p)
                    {
                        ant = xcab;
                        xcab = xcab.get_sig();
                        i++;
                    }
                    x = xcab.get_dato();
                    ant.set_sig(xcab.get_sig());//hace el enlace en para eliminar elemento;
                }
                cant--;
                return true;
            }
            else
                return false;

        }

        //busca el elemento en la lista y devuelve su posicion
        public int buscar (int x)
        {
            int i = 1;
            nodo xcab = cab;
            while (i<=cant && x!=xcab.get_dato())
            {
                i++;
                xcab = xcab.get_sig();
            }
            if (i <= cant)
            {
                return i;
            }
            else
                return -1;
        }

        public bool recuperar (ref int x, int p)
        {
            nodo xcab = cab;
            int i = 1;

            if (p >= 1 && p <= cant)//primero valido posicion
            {
                while(i<p)
                {
                    xcab = xcab.get_sig();
                    i++;
                }
                x = xcab.get_dato();
                return true;
            }
            else
                return false;
        }


        public void mostrar_l()
        {
            nodo xcab;
            xcab = cab;
            if (!vacia())
            {
                Console.WriteLine("Elementos de la lista");
                while (xcab != null)
                {
                    Console.WriteLine(" - " + xcab.get_dato());
                    xcab = xcab.get_sig();
                }
            }
            else
                Console.WriteLine("Lista VACIA");
        }

        public bool vacia()
        {
            if (cant == 0)
                return
                        true;
            else
                return
                        false;
        }
        public bool primero(ref int x)
        {
            if (!vacia())
            {
                x = cab.get_dato();
                return true;
            }
            else
                return false;
        }

        public bool ultimo(ref int x)
        {
            nodo xcab = cab;
            if (!vacia())
            {
                while(xcab.get_sig()!=null)
                {
                    xcab = xcab.get_sig();
                }
                x = xcab.get_dato();
                return true;
            }
            else
                return false;

        }

        public bool siguiente(int p, ref int p1)
        {
            if ((p >= 0) && (p < cant))
            {
                p1 = p + 1;
                return true;
            }
            else
                return false;
        }


        public bool anterior(int p, ref int p1)
        {

            if ((p > 0) && (p <= cant))
            {
                p1 = p-1;
                return true;
            }
            else
                return false;
        }


    }
}
