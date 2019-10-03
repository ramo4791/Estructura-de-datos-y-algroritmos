using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Ejer07
{
    class monticulo
    {
        int[] datos;
        int tam;

        public monticulo (int xt)
        {
            tam = xt;
            datos = new int[xt];
            datos[0] = 0; 
        }

        public bool lleno ()
        {
            if (datos[0] == tam - 1)
                return true;
            else
                return false;
        }

        public bool vacio ()
        {
            if (datos[0] == 0)
                return true;
            else
                return false;
        }

        public bool insertar (int xn)
        {
            if (lleno())
            {
                return false;
            }
            else
            {
                int i = ++datos[0];
                datos[i] = xn;//propiedad de estructura  
                
                while(((i/2)!=0) &&(xn < datos[i/2]))// revisa primero si no tiene padre y luego orden
                {                                     //intercambia si es necesario
                    datos[i] = datos[i / 2];
                    datos[i / 2] = xn;
                    i = i / 2;
                }


                return true;
            }
        }

        public bool suprimir_min (ref int xn)
        {
            int aux,i;
            if (vacio())
            {
                return false;
            }
            else
            {
                int cant = datos[0];
                xn = datos[1];//devuelve el de mas prioridad
                datos[1] = datos[cant];//mantiene la estructura y sube el ultimo del arbol
                cant--;
                i = 1;//me paro en la raiz
                datos[0]=cant;//el ultimo ahora es el anterior y tiene un elemento menos el arbol
                while ((i*2<=cant) ||( (i*2)+1<=cant))
                {
                    aux = datos[i];
                    if ((i*2)+1<=cant)
                    {
                        if (datos[i*2]<datos[(i*2)+1])//tiene 2 hijos
                        {
                            if (datos[i]>datos[i*2])
                            {
                                datos[i] = datos[i * 2];
                                datos[i * 2] = aux; //intercambio con izq si el menor hijo es el izquierdo
                            }
                            i = i * 2;
                        }
                        else
                        {
                            if (datos[i]>datos[(i*2)+1])
                            {
                                datos[i] = datos[(i * 2) + 1];
                                datos[(i * 2) + 1] = aux;
                            }
                            i = (i * 2) + 1;
                        }
                    }
                    else
                    {
                        if (i*2<=cant)//tiene un hijo y es el izquierdo
                        {
                            if(datos[i]>datos[i*2])
                            {
                                datos[i] = datos[i * 2];
                                datos[i * 2] = aux;
                            }
                            i = i * 2;
                        }
                    }
                } // sale del mientras cuando no tiene mas hijos por analizar
                return true;
            }
        }



    }
}
