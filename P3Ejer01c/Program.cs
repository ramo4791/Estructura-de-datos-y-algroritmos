using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Ejer01c
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaC lc = new ListaC(10);
            lc.mostrar_p();
            Console.ReadLine();

            int op, dato = 0, pos;

            do
            {
                op = M.menu();
                switch (op)
                {
                    case 'a':
                        Console.Write("Ingrese numero a la lista  : ");
                        dato = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese posicion < 1 y cant +1>  : ");
                        pos = int.Parse(Console.ReadLine());
                        if (lc.insertar_c(dato,pos))
                            Console.WriteLine("se inserto correcto");
                        else
                            Console.WriteLine("No se pudo insertar");
                        Console.ReadLine();
                        break;
                    case 'b':
                        Console.Write("Ingrese posicion para suprimir < 1 y cant +1>  : ");
                        pos = int.Parse(Console.ReadLine());
                        if (lc.suprimir_c(ref dato, pos))
                            Console.WriteLine("se suprimio correcto el elemento {0} de la posicion {1}",dato,pos);
                        else
                            Console.WriteLine("No se pudo suprimir");

                        Console.ReadLine();
                        break;
                    case 'c':
                        lc.mostrar_lc();
                        Console.ReadLine();
                        break;
                    //case 'd':
                    //    Console.WriteLine("\n Ingrese elemento para buscar su posicion ");
                    //    dato = int.Parse(Console.ReadLine());
                    //    pos = lp.buscar(dato);
                    //    if (pos == -1)
                    //        Console.WriteLine("No se encontro");
                    //    else
                    //        Console.WriteLine("El dato {0} se encuentra en la posicion {1}", dato, pos);
                    //    Console.ReadLine();
                    //    break;
                    //case 'e':
                    //    Console.Write("Ingrese posicion para recuperar entre < 1 y cant>  : ");
                    //    pos = int.Parse(Console.ReadLine());
                    //    if (lp.recuperar(ref dato, pos))
                    //        Console.WriteLine("El elemento recuperado de la pos {0 } es  {1}", pos, dato);
                    //    else
                    //        Console.WriteLine("ERROR ");
                    //    Console.ReadLine();
                    //    break;
                    //case 'f':
                    //    if (lp.primero(ref dato))
                    //        Console.WriteLine("El primer elemento es : " + dato);
                    //    else
                    //        Console.WriteLine("ERROR");
                    //    Console.ReadLine();
                    //    break;
                    //case 'g':
                    //    if (lp.ultimo(ref dato))
                    //        Console.WriteLine("El ultimo elemento es : " + dato);
                    //    else
                    //        Console.WriteLine("ERROR");
                    //    Console.ReadLine();
                    //    break;
                    //case 'h':
                    //    Console.Write("Ingrese posicion para buscar siguiente : ");
                    //    pos = int.Parse(Console.ReadLine());
                    //    if (lp.siguiente(pos, ref dato))
                    //        Console.WriteLine("La posicion siguiente es : " + dato);
                    //    else
                    //        Console.WriteLine("ERROR");
                    //    Console.ReadLine();
                    //    break;
                    //case 'i':
                    //    Console.Write("Ingrese posicion para buscar anterior : ");
                    //    pos = int.Parse(Console.ReadLine());
                    //    if (lp.anterior(pos, ref dato))
                    //        Console.WriteLine("La posicion anterior es : " + dato);
                    //    else
                    //        Console.WriteLine("ERROR");
                    //    Console.ReadLine();
                    //    break;
                    case 'j':
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta ..intente otra vez ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            while (op != 'j');

           Console.ReadLine();
        }
    }
}
 