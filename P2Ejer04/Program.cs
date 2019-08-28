using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Ejer04
{
    class Program
    {
        static void Main(string[] args)

        {
            //Ejercicio Nº 4: Realizar un programa iterativo, que usando una pila,
            //muestre n números de la serie de Fibonacci y el valor de la suma de los 
            //    mismos, donde n es ingresado por teclado.

            Console.WriteLine("Ingrese el tamaño de la Serie de Fibonacci");
            int tam = int.Parse(Console.ReadLine());
            pila serie = new pila(tam);
            int unoantes = 1, dosantes = 0, actual;

            serie.insertar(dosantes);
            serie.insertar(unoantes);

            for (int i = 2; i < tam; i++)
            {
                actual = unoantes + dosantes;
                serie.insertar(actual);
                dosantes = unoantes;
                unoantes = actual;
            }

            serie.mostrar();

            int total = 0;
            for (int i = 0; i < tam; i++)
            {
                total += serie.suprimir();
            }

            Console.WriteLine("Total de la serie para : {0} componentes = {1} ", tam, total);

            Console.ReadLine();

        }
    }
}
