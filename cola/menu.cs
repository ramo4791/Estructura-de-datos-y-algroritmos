using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cola
{
    public static class M
    {
        public static char menu()
        {
            string a;
            char b;
            Console.Clear();
            Console.WriteLine("a: Insertar en Cola Sec");
            Console.WriteLine("b: Suprimir de Cola Sec");
            Console.WriteLine("c: Mostrar Cola Sec");
            Console.WriteLine("d: Insertar en Cola Enl");
            Console.WriteLine("e: Suprimir de Cola Enl");
            Console.WriteLine("f: Mostrar Cola Enl");
            Console.WriteLine("g: Salir");
            Console.Write("\n\nOPCION : ");
            a = Console.ReadLine();
            //Console.ReadLine();
            
            b = Char.Parse(a);
            return b;
        }
    }
}
