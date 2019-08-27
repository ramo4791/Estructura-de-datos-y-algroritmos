using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cola
{
    class Program
    {
        static void Main(string[] args)
        {
            int m,dato;
            Cola c;
            Console.WriteLine("Ingrese maximo de cola : ");
            m = int.Parse(Console.ReadLine());
            c = new Cola(m);
            colalista cl;
            cl = new colalista();
         
     
            char op;

            do
            {
                op = M.menu();
                switch (op)
                {
                    case 'a':
                        Console.Write("Ingrese numero a la cola : ");
                        dato = int.Parse(Console.ReadLine());
                        c.insertar(dato);
                        Console.ReadLine();
                        break;
                    case 'b':
                        dato = c.suprimir();
                        Console.WriteLine("El elemento {0} fue eliminado", dato);
                        Console.ReadLine();
                        break;
                    case 'c':
                        c.recorrer();
                        Console.ReadLine();
                        break;
                    case 'd':
                        Console.Write("Ingrese numero a la cola : ");
                        dato = int.Parse(Console.ReadLine());
                        cl.insertar_colal(dato);
                        break;
                    case 'e':
                        dato = cl.suprimir_colal();
                        Console.WriteLine("El elemento {0} fue eliminado", dato);
                        Console.ReadLine();
                        break;
                    case 'f':
                        cl.recorrer_colal();
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
