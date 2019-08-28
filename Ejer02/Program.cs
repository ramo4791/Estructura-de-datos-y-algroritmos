using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que dado un numero decimal obtenga su representarán binaria;

            Console.WriteLine("Ingrese numero para calcular binario");
            pila bin = new pila(10);
            int entero = int.Parse(Console.ReadLine());
            int cociente = entero;
            int modulo = 0;
            while (cociente > 1)
            {
                modulo = cociente % 2;
                cociente = cociente / 2;
                bin.insertar(modulo);
            }
            if (cociente == 1)
                bin.insertar(cociente);
            bin.mostrar();
            Console.ReadLine();
        }
    }
}
