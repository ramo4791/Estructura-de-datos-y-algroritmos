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

            if (l.insertar_p(2, 1))
                Console.WriteLine("se inserto correcto");
            else
                Console.WriteLine("No se pudo insertar");
            if (l.insertar_p(3, 1))
                Console.WriteLine("se inserto correcto");
            else
                Console.WriteLine("No se pudo insertar");
            if (l.insertar_p(4, 2))
                Console.WriteLine("se inserto correcto");
            else
                Console.WriteLine("No se pudo insertar");
            if (l.insertar_p(5, 3))
                Console.WriteLine("se inserto correcto");
            else
                Console.WriteLine("No se pudo insertar");



            l.mostrar_lista();
            Console.WriteLine("\n Buscar posicion de elemento 5 : " + l.buscar(5));

            Console.ReadLine();
        }
    }
}
