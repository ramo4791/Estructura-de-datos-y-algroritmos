using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaE
{
    class Program
    {
        static void Main(string[] args)
        {
            int op,dato =0,pos;
            listap_enlazada lp = new listap_enlazada();

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
                        if (lp.insertar_p(dato, pos))
                            Console.WriteLine("se inserto correcto");
                        else
                            Console.WriteLine("No se pudo insertar");
                        Console.ReadLine();
                        break;
                    case 'b':
                        Console.Write("Ingrese posicion para eliminarn< 1 y cant>  : ");
                        pos = int.Parse(Console.ReadLine());
                        if (lp.suprimir(ref dato, pos))
                            Console.WriteLine("El elemento {0} fue eliminado", dato);
                        else
                            Console.WriteLine("ERROR ");
                        Console.ReadLine();
                        break;
                    case 'c':
                        lp.mostrar_l();
                        Console.ReadLine();
                        break;
                    case 'd':
                        Console.WriteLine("\n Ingrese elemento para buscar su posicion ");
                        dato = int.Parse(Console.ReadLine());
                        pos = lp.buscar(dato);
                        if (pos == -1)
                            Console.WriteLine("No se encontro");
                        else
                            Console.WriteLine("El dato {0} se encuentra en la posicion {1}",dato,pos);                           
                        Console.ReadLine();
                        break;
                    //case 'e':
                    //    Console.Write("Ingrese posicion para recuperar entre < 1 y cant>  : ");
                    //    pos = int.Parse(Console.ReadLine());
                    //    if (l.recuperar(ref dato, pos))
                    //        Console.WriteLine("El elemento recuperado de la pos {0 } es  {1}",pos, dato);
                    //    else
                    //        Console.WriteLine("ERROR ");
                    //    Console.ReadLine();
                    //    break;
                    //case 'f':
                    //    if (l.primero(ref dato))
                    //        Console.WriteLine("El primer elemento es : " + dato);
                    //    else
                    //        Console.WriteLine("ERROR");
                    //    Console.ReadLine();
                    //    break;
                    //case 'g':
                    //    if (l.ultimo(ref dato))
                    //        Console.WriteLine("El ultimo elemento es : " + dato);
                    //    else
                    //        Console.WriteLine("ERROR");
                    //    Console.ReadLine();
                    //    break;
                    //case 'h':
                    //    Console.Write("Ingrese posicion para buscar siguiente : ");
                    //    pos = int.Parse(Console.ReadLine());
                    //    if (l.siguiente (pos,ref dato))
                    //        Console.WriteLine("La posicion siguiente es : " + dato);
                    //    else
                    //        Console.WriteLine("ERROR");
                    //    Console.ReadLine();
                    //    break;
                    //case 'i':
                    //    Console.Write("Ingrese posicion para buscar anterior : ");
                    //    pos = int.Parse(Console.ReadLine());
                    //    if (l.anterior(pos, ref dato))
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
