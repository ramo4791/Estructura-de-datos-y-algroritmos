using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Ejer01c
{
    public static class M
    {
        public static char menu()
        {
            string a;
            char b;
            Console.Clear();
            Console.WriteLine("a: Insertar Lista Cursor");
            Console.WriteLine("b: Suprimir Lista Cusor");
            Console.WriteLine("c: Mostrar Lista Cursor");
            Console.WriteLine("d: Buscar en Lista");
            Console.WriteLine("e: Recuperar");
            Console.WriteLine("f: Primer Elemento");
            Console.WriteLine("g: Ultimo Elemento");
            Console.WriteLine("h: Siguiente");
            Console.WriteLine("i: Anterior");
            Console.WriteLine("j: Salir");
            Console.Write("\n\nOPCION : ");
            a = Console.ReadLine();
            //Console.ReadLine();
            
            b = Char.Parse(a);
            return b;
        }
    }
}
