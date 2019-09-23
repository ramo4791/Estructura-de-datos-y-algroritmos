using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P4Ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            ABus a = new ABus();
            string bus;
            ///Principal
            string linea;
            string[] datos = new string[4]; //como son 10 atributos a separar 
            StreamReader file = new StreamReader(@"C:\Users\omar\source\repos\EstructuraDatos\P4Ejer02\alimentos-libres-de-gluten.csv");
            linea = file.ReadLine();
            datos = linea.Split(','); //Split, recibe el carácter separador
            while ((linea = file.ReadLine()) != null)
            {

                datos = linea.Split(','); //Split, recibe el carácter separador
                datos[2] = datos[2].Replace("\"","");
                a.insertar(datos[2]);
                
            }
            nodo aux = a.Raiz;

            Console.WriteLine("Ingrese producto  a buscar :");
            bus = Console.ReadLine();
            if (a.buscar(ref aux, bus))
                Console.WriteLine("El producto se encuentra ");
            else
                Console.WriteLine("El producto  no se encuentra");

            //a.inorden();
            Console.ReadLine();
        }
    }
}
