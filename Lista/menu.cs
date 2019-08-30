using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    public static class M
    {
        public static char menu()
        {
            string a;
            char b;
            Console.Clear();
            Console.WriteLine("a: Insertar Lista Secuencial");
            Console.WriteLine("b: Suprimir Lista Secuencial");
            Console.WriteLine("c: Mostrar Lista Secuencial");
            Console.WriteLine("d: Buscar en Lista");
            Console.WriteLine("e: ");
            Console.WriteLine("f: ");
            Console.WriteLine("g: Salir");
            Console.Write("\n\nOPCION : ");
            a = Console.ReadLine();
            //Console.ReadLine();
            
            b = Char.Parse(a);
            return b;
        }
    }
}
