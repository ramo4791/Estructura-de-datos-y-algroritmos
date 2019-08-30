using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            lista l = new lista(10);
            int op,dato,pos;

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
                        if (l.insertar_p(dato, pos))
                            Console.WriteLine("se inserto correcto");
                        else
                            Console.WriteLine("No se pudo insertar");
                        Console.ReadLine();
                        break;
                    case 'b':
                        //dato = p.suprimir();
                        //Console.WriteLine("El elemento {0} fue eliminado", dato);
                        Console.ReadLine();
                        break;
                    case 'c':
                        l.mostrar_lista();
                        Console.ReadLine();
                        break;
                    case 'd':
                        Console.WriteLine("\n Buscar posicion de elemento 5 : " + l.buscar(5));
                        Console.ReadLine();
                        break;
                    case 'e':
                        //dato = pl.suprimir_lista();
                        //Console.WriteLine("El elemento {0} fue eliminado", dato);
                        Console.ReadLine();
                        break;
                    case 'f':
                        l.mostrar_lista();
                        Console.ReadLine();
                        break;
                    case 'g':
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta ..intente otra vez ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }


            }
            while (op != 'g');

           




            Console.ReadLine();
        }
    }
}
