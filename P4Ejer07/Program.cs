using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Ejer07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -1;
            monticulo m = new monticulo(13);
            m.insertar(10);
            m.insertar(20);
            m.insertar(30);
            m.insertar(40);
            m.insertar(50);
            m.insertar(60);
            m.insertar(70);
            m.insertar(80);
            m.insertar(90);
            m.insertar(100);
            m.insertar(35);
            m.suprimir_min(ref n);
            m.insertar(45);

            Console.ReadLine();

        }
    }
}
