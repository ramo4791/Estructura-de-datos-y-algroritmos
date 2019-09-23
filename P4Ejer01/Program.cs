using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            ABus a = new ABus();
            nodo rr = a.Raiz;

            //a.insertar(70);
            //a.insertar(47);
            //a.insertar(92);
            //a.insertar(35);
            //a.insertar(68);
            //a.insertar(83);
            //a.insertar(100);
            //a.insertar(79);
            a.insertar2(70,ref rr);
            a.Raiz = rr;
            a.insertar2(47,ref rr);
            a.Raiz = rr;
            a.insertar2(92, ref rr);
            a.Raiz = rr;

            a.insertar2(35, ref rr);
            a.Raiz = rr;

            a.insertar2(68, ref rr);
            a.Raiz = rr;

            a.insertar2(83, ref rr);
            a.Raiz = rr;

            a.insertar2(100, ref rr);
            a.Raiz = rr;

            a.insertar2(79, ref rr);
            a.Raiz = rr;



            a.inorden();
            a.preorden();
            a.posorden();
            nodo aux = a.Raiz;

            if (a.buscar(ref aux, 92))
                Console.WriteLine("\n El elemento se encuentra");
            else
                Console.WriteLine("\n NO se encuentra");
            Console.WriteLine(aux.getDato());
            a.inorden();
            

            Console.WriteLine(a.grado(aux));
            nodo padre = a.padre(79);
            if (padre != null)
                Console.WriteLine(padre.getDato());
            else
                Console.WriteLine("No existe el padre");
            a.suprimir(47);
            a.inorden();

            //a.suprimir(47);
            //a.posorden();

            //a.suprimir(70);
            //a.posorden();
            Console.ReadLine();

        }
    }
}
