using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    public static class M
    {
        public static char menu()
        {
            string a;
            char b;
            Console.Clear();
            Console.WriteLine("a: Insertar Pila Secuencial");
            Console.WriteLine("b: Suprimir Pila Secuencial");
            Console.WriteLine("c: Mostrar Pila Secuencial");
            Console.WriteLine("d: Insertar Pila Enlazada");
            Console.WriteLine("e: Suprimir Pila Enlazada");
            Console.WriteLine("f: Mostrar Pila Enlazada");
            Console.WriteLine("g: Salir");
            Console.Write("\n\nOPCION : ");
            a = Console.ReadLine();
            //Console.ReadLine();
            
            b = Char.Parse(a);
            return b;
        }
    }
}
