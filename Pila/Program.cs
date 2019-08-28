using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            pila p = new pila(6);
            pilalista pl = new pilalista();
            int dato = 0;

            do
            {
                op = M.menu();
                switch (op)
                {
                    case 'a':
                        Console.Write("Ingrese numero a la pila : ");
                        dato = int.Parse(Console.ReadLine());
                        p.insertar(dato);
                        Console.ReadLine();
                        break;
                    case 'b':
                        dato = p.suprimir();
                        Console.WriteLine("El elemento {0} fue eliminado", dato);
                        Console.ReadLine();
                        break;
                    case 'c':
                        p.mostrar();
                        Console.ReadLine();
                        break;
                    case 'd': Console.Write("Ingrese numero a la pila : ");
                        dato = int.Parse(Console.ReadLine());
                        pl.insertar_lista(dato);
                        Console.ReadLine();
                        break;
                    case 'e': dato = pl.suprimir_lista();
                        Console.WriteLine("El elemento {0} fue eliminado", dato);
                        Console.ReadLine();
                        break;
                    case 'f': pl.mostrar_lista();
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

           
    

    


        }

        
    }
}
