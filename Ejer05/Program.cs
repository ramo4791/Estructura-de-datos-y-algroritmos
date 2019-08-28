using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer05
{
    class Program
    {
        static void Main(string[] args)
        {
            piladoble pd = new piladoble(5);
            int op,dato;
            do
            {
                op = M.menu();
                switch (op)
                {
                    case 'a':
                        Console.Write("Ingrese numero a la pila1 : ");
                        dato = int.Parse(Console.ReadLine());
                        pd.insertar1(dato);
                        Console.ReadLine();
                        break;
                    case 'b':
                        dato = pd.suprimir1();
                        Console.WriteLine("El elemento {0} fue eliminado de pila 1", dato);
                        Console.ReadLine();
                        break;
                    case 'c':
                        pd.mostrar1();
                        Console.ReadLine();
                        break;
                    case 'd':
                        Console.Write("Ingrese numero a la pila2 : ");
                        dato = int.Parse(Console.ReadLine());
                        pd.insertar2(dato);
                        Console.ReadLine();
                        break;
                    case 'e':
                        dato = pd.suprimir2();
                        Console.WriteLine("El elemento {0} fue eliminado de pila 2", dato);
                        Console.ReadLine();
                        break;
                    case 'f':
                        pd.mostrar2();
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
