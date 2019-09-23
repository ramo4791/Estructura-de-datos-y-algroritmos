using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Ejer02
{
    class ABus
    {
        private nodo raiz;

        internal nodo Raiz { get => raiz; set => raiz = value; }

        public ABus ()
        {
            Raiz = null;
            
        }

        public bool vacio (nodo xr)
        {
            if (xr == null)
                return true;
            else
                return false;
        }
        public bool insertar (string xn)
        {
            if (raiz == null)
            {
                raiz = new nodo (xn);
                return true;
            }
            else
            {
                
                if (insertar_rec(raiz,  xn))
                    return true;
                else
                    return false;
            }
        }

        //public bool buscar_rec(int x , nodo xr)
        //{
        //    if (vacio(xr))
        //        return false;
        //    else
        //        if (x == xr.Dato)
        //            return true;
        //        else
        //                if (x < xr.Dato)
        //                   return buscar_rec(x, xr.Izq);
        //                else
        //                    return buscar_rec(x, xr.Der);
        //}



        public bool insertar_rec(  nodo xr , string xn)
        {
                      
            if (xr.getDato() == xn)
            {
                return false;
            }
            else
            {
                //if (xn.CompareTo(xr.getDato()) < 0)
                if (String.Compare(xn,xr.getDato()) < 0)
                {
                    if (xr.getIzq() == null)
                    {
                        xr.setIzq(new nodo(xn));
                    }
                    else
                        return insertar_rec(xr.getIzq(), xn);
                }
                else
                {
                    if (xr.getDer() == null)
                    {
                        xr.setDer(new nodo(xn));
                    }
                    else
                        return insertar_rec(xr.getDer(), xn);
                }
                return true;
            }                
        }


        public bool buscar (ref nodo xr, string xn)//devueleve el nodo 
        {
            if(xr==null)
            {
                return false;
            }
            else
            {
                //if (xr.getDato().CompareTo(xn) == 0)
                if (string.Compare(xn,xr.getDato()) == 0)
                    return true;
                else
                {
                    //if (xn.CompareTo(xr.getDato()) < 0)
                    if (string.Compare(xn, xr.getDato()) < 0)
                    {
                        xr = xr.getIzq();
                        return buscar(ref xr, xn);
                    }
                    else
                    {
                        xr = xr.getDer();
                        return buscar(ref xr,xn);
                    }
                }
            }
        }

        public bool buscar2(ref nodo xr, string xn, ref nodo xp)//develve el padre en xp
        {
            if (xr == null)
            {
                return false;
            }
            else
            {
                if (xr.getDato() == xn)
                    return true;
                else
                {
                    if (xn.CompareTo(xr.getDato()) < 0)
                    {
                        xp = xr;
                        xr = xr.getIzq();
                        return buscar2(ref xr, xn,ref xp);
                    }
                    else
                    {
                        xp = xr;
                        xr = xr.getDer();
                        return buscar2(ref xr, xn,ref xp);
                    }
                }
            }
        }

        public nodo padre (string xn)
        {
            nodo p = null;
            nodo aux = raiz;
            if (raiz == null)
                return null;
            else
            {
                if (raiz.getDato() == xn)
                    return null;
                else
                {
                    if (buscar2(ref aux, xn, ref p))
                        return p;
                    else
                        return null;
                }
            }
        }


        public int grado (nodo xr)
        {
            if (xr != null)
            {
                if (xr.getIzq() != null && xr.getDer() != null)
                {
                    return 2;
                }
                else
                {
                    if (xr.getIzq() != null || xr.getDer() != null)
                    {
                        return 1;
                    }
                    else
                        return 0;
                }
            }
            else
                return -1;
        }


        //public bool padre (int xn, ref nodo xpadre)
        //{
        //    if (raiz == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        if (raiz.getDato()==xn)
        //        {
        //            return false;
        //        }
        //    }            
        //}
        

        public bool suprimir (string xn)
        {
            nodo aux = raiz;
            nodo p = null;

            if (buscar2(ref aux, xn,ref p))
            {

                switch (grado(aux))
                {
                    case 0:
                        if (p!=null)
                        {
                         if(xn.CompareTo(p.getDato()) < 0)
                            p.setIzq(null);
                         else
                            p.setDer(null);
                        }
                        if (aux==raiz)
                        {
                            raiz = null;
                        }
                        break;
                    case 1:
                        if(aux.getDato().CompareTo(p.getDato()) < 0)
                        {
                            if (aux.getDer() != null)
                                p.setIzq(aux.getDer());
                            else
                                p.setIzq(aux.getIzq());
                        }
                        else
                        {
                            if (aux.getDer() != null)
                                p.setDer(aux.getDer());
                            else
                                p.setDer(aux.getIzq());
                        }

                        break;
                    case 2:
                        nodo m = aux.getIzq();
                        maximo(aux.getIzq(), ref m);
                        suprimir(m.getDato());
                        aux.setDato(m.getDato());//al padre del nodo a borrar le asigno el dato del  maximo
                        break;

                }
                return true;
            }
            else
                return false;
        }

        public void maximo (nodo xr,ref nodo max)
        {
            if (xr!=null)
            {
                if (xr.getDato().CompareTo(max.getDato()) >0)
                {
                    max = xr;
                }
                maximo(xr.getIzq(), ref max);
                maximo(xr.getDer(), ref max);
            }
                
        }

        public bool insertar2 (string xn, ref nodo xr)
        {
            nodo aux;
            if (xr == null)
            {
                xr = new nodo (xn);
                return true;
            }
            else
            {
                if (xn==xr.getDato())
                {
                    Console.WriteLine("Error ya existe");
                    return false;
                }
                else
                {
                    if(xn.CompareTo(xr.getDato()) < 0)
                    {
                        aux = xr.getIzq();
                        insertar2(xn, ref aux);
                        xr.setIzq(aux);
                    }
                    else
                    {
                        aux = xr.getDer();
                        insertar2(xn, ref aux);
                        xr.setDer(aux);
                    }
                    return true;
                }
                
            }
        }


        public void inorden()
        {
            Console.WriteLine("    Recorrido InOrden  \n");
            inorden_rec(raiz);
        }
        public void inorden_rec(nodo xr)
        {
            if (!(xr==null))
            {
                inorden_rec(xr.getIzq());
                Console.WriteLine( xr.getDato());
                inorden_rec(xr.getDer());
            }

        }

        public void preorden()
        {
            Console.WriteLine(" \n   Recorrido PreOrden  \n");
            preorden_rec(raiz);
        }
        public void preorden_rec(nodo xr)
        {
            if (!(xr == null))
            {
                Console.Write("  {0} ", xr.getDato());
                preorden_rec(xr.getIzq());
                preorden_rec(xr.getDer());
            }

        }

        public void posorden()
        {
            Console.WriteLine(" \n   Recorrido PreOrden  \n");
            posorden_rec(raiz);
        }
        public void posorden_rec(nodo xr)
        {
            if (!(xr == null))
            {
                posorden_rec(xr.getIzq());
                posorden_rec(xr.getDer());
                Console.Write("  {0} ", xr.getDato());
            }

        }

    }
}
