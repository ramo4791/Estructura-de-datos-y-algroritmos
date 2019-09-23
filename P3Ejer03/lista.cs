using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Ejer03
{
    class lista
    {
        private int ult;
        private int tamaño;
        private datos[] elem;


        public lista(int xtam)
        {
            tamaño = xtam;
            elem = new datos[tamaño];
            //for (int i = 0; i < tamaño; i++)
            //    elem[i] = new datos();
            ult = -1;
        }

        public bool lista_vacia()
        {
            if (ult == -1)
                return true;
            else
                return false;
        }

        public bool insertar_p (int x, int p)
        {
                       
            if (ult == tamaño - 1)
            {
                Console.WriteLine("No hay lugar");
                return false;
            }
            else
            {
                p = p - 1;//posicion en lista comienza en 1 y posicion fisica en arreglo en 0
                if ((p >= 0) && (p <= ult+1 ))
                {
                    if (p==ult+1)//si va al final de la lista o esta vacia
                    {
                        
                        elem[p].sup = x;
                    }
                    else
                    {
                        for (int i=ult+1;i>p; i--)
                        {
                            elem[i] = elem[i-1];
                        }
                        elem[p].sup = x;
                    }
                    ult++;
                    return true;
                }
                else
                {
                    Console.WriteLine("verificar posicion entre 1 y n+1");
                    return false;
                }
            }
        }
        public bool insertar_o(datos x)
        {
            int p,u,m;
            datos aux = new datos();

            if (ult == tamaño - 1)
            {
                Console.WriteLine("No hay lugar");
                return false;
            }
            else
            {
                    p = 0;
                    u = ult;

                    while (p <= u)
                    {
                        m = (p + u) / 2;

                        if (x.sup <=elem[m].sup)
                            u = m - 1;
                        else
                            p = m + 1;
                    }                  
                    for (int i = ult + 1; i > p; i--)
                    {
                        elem[i] = elem[i - 1];
                    }
                    aux.nombre = x.nombre;
                    aux.sup = x.sup;
                    elem[p] = aux;                                   
                    ult++;               
                return true;                           
            }
        }

        public bool suprimir (ref double x,  int p)
        {
            if (!lista_vacia())
            {
                p = p - 1;
                if ((p >= 0) && (p <= ult ))
                {
                    x = elem[p].sup;
                    for(int i=p; i<ult;i++)
                    {
                        elem[i] = elem[i + 1];
                    }
                    ult--;
                    return true;
                }
                else
                {
                    Console.WriteLine("verificar posicion entre 1 y n");
                    return false;
                }


            }
            else
            {
                Console.WriteLine("Lista vacia ");
                return false;
            }
        }

        public int buscar (int x)
        {
            int i = 0;
            if (!lista_vacia())
            {
                while ((i <= ult) && (elem[i].sup != x))//evalua por cortocircuito
                    i++;
                if (i > ult)
                    return -1;
                else
                    return i+1;
            }
            return -1;
        }

        public bool recuperar (ref double x,  int p)
        {
            if (!lista_vacia())
            {
                p = p - 1;
                if ((p >= 0) && (p <= ult))
                {
                    x = elem[p].sup;          
                    return true;
                }
                else
                {
                    Console.WriteLine("verificar posicion entre 1 y n");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Lista vacia ");
                return false;
            }
        }

        public void mostrar_lista()
        {
            Console.WriteLine("Elementos de la lista ");
            for (int i = 0; i <= ult; i++)
                Console.WriteLine(" Nombre: {0}    Superficie : {1:f} ",elem[i].nombre,elem[i].sup );
        }

        public bool primero (ref double x)
        {
            if (!lista_vacia())
            {
                x = elem[0].sup;
                return true;
            }
            else
                return false;
        }

        public bool ultimo (ref double x)
        {
            if (!lista_vacia())
            {
                x = elem[ult].sup;
                return true;
            }
            else
                return false;

        }

        public bool siguiente(int p, ref int p1)
        {
            p--;
            if ((p >= 0) && (p < ult))
            {
            p1 = p+2;
            return true;
            }
            else
                return false;
        }

        
        public bool anterior (int p, ref int p1)
        {
            p--;
        
            if ((p > 0) && (p <= ult))
            {
                p1 = p;
                return true;
            }
            else
                return false;
        }
    }
}
