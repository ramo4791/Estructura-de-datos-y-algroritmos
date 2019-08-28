using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer05
{
    public static class M
    {
        public static char menu()
        {
            string a;
            char b;
            Console.Clear();
            Console.WriteLine("a: Insertar Pila1");
            Console.WriteLine("b: Suprimir Pila1");
            Console.WriteLine("c: Mostrar Pila1");
            Console.WriteLine("d: Insertar Pila2");
            Console.WriteLine("e: Suprimir  Pila2");
            Console.WriteLine("f: Mostrar Pila2");
            Console.WriteLine("g: Salir");
            Console.Write("\n\nOPCION : ");
            a = Console.ReadLine();
            //Console.ReadLine();
            
            b = Char.Parse(a);
            return b;
        }
    }
}
