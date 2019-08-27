using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer08
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola cp = new Cola(100);
            double frec_llegada;
            int tiempo_pre,tespera, maxte;

            double prob_lleg;
            Random rdn = new Random();
            int reloj=0;
            int ts;
            Console.WriteLine("Ingrese tiempo de simulacion en minutos :");
            ts = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tiemmpo promedio de preparacion del plato");
            tiempo_pre = int.Parse( Console.ReadLine());
            Console.WriteLine("Ingrese frecuencia  de llegada de clientes");
            frec_llegada = double.Parse( Console.ReadLine());
            prob_lleg = (1 / frec_llegada) * 100;
            int cocinando = tiempo_pre;
            int clienatend = 0;
            int clientra = 0;

            maxte = 0;
            while (reloj < ts)
            {
                if (rdn.Next(101)<prob_lleg)
                {
                    cp.insertar(reloj);
                    clientra++;
                }
                if (cocinando == tiempo_pre)
                {
                    if (!cp.vacia())
                    {
                        tespera = (reloj - cp.suprimir()) + tiempo_pre;
                        if (tespera > maxte)
                            maxte = tespera;
                        cocinando = 0;
                        clienatend++;
                    }
                }
                if (cocinando < tiempo_pre)
                {
                    cocinando++;
                }

                reloj++;
            }
            //cp.recorrer();
            Console.WriteLine("Tiempo maximo de espera del cliente :  " + maxte);
            
            Console.WriteLine("Cantidad de clientes en que faltan atender :  " + cp.cantidad());
            Console.WriteLine("Cantidad de clientes atendidos :  " + clienatend);
            Console.WriteLine("Cantidad de clientes entraron :  " + clientra);

            Console.ReadLine();

        }
    }
}
