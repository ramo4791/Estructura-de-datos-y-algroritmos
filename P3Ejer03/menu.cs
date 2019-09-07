using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Ejer03
{
    public static class M
    {
        public static char menu()
        {
            string a;
            char b;
            Console.Clear();
            Console.WriteLine("a: Insertar Lista Enlazada por posicion");
            Console.WriteLine("b: Suprimir Lista Enlazada");
            Console.WriteLine("c: Mostrar Lista Enlazada");
            Console.WriteLine("d: Buscar en Lista");
            Console.WriteLine("e: Recuperar");
            Console.WriteLine("f: Primer Elemento");
            Console.WriteLine("g: Ultimo Elemento");
            Console.WriteLine("h: Siguiente");
            Console.WriteLine("i: Anterior");
            Console.WriteLine("j: Insertar Lista Enlazada Ordenado");

            Console.WriteLine("k: Salir");
            Console.Write("\n\nOPCION : ");
            a = Console.ReadLine();
            //Console.ReadLine();
            
            b = Char.Parse(a);
            return b;
        }
    }
}
