using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Ejer06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cantidad de Discos");
            int tamP = int.Parse(Console.ReadLine());
            pila Pila1 = new pila(tamP);
            pila Pila2 = new pila(tamP);
            pila Pila3 = new pila(tamP);

            void restaurar(int xp, int d)

            {
                switch (xp)
                {
                    case 1:
                        Pila1.insertar(d);
                        break;
                    case 2:
                        Pila2.insertar(d);
                        break;
                    case 3:
                        Pila3.insertar(d);
                        break;
                }
            }

            for (int i = tamP; i > 0; i--)
                Pila1.insertar(i);


            int ps, pp;//ps pila saca pp pila pone
            int disco = 0;
            int cm = 0;
            while (!Pila3.pila_llena())
            {
                Console.Clear();
                Console.WriteLine("\n PILA1");
                Pila1.mostrar();
                Console.WriteLine("\n PILA2");
                Pila2.mostrar();
                Console.WriteLine("\n PILA3");
                Pila3.mostrar();
                Console.WriteLine("\nIngrese pila donde sacar disco <1-2-3>");
                ps = int.Parse(Console.ReadLine());
                switch (ps)
                {
                    case 1:
                        if (!Pila1.pila_vacia())
                            disco = Pila1.suprimir();
                        else
                            Console.WriteLine("Pila 1 Vacia no se puede sacar disco");
                        break;

                    case 2:
                        if (!Pila2.pila_vacia())
                            disco = Pila2.suprimir();
                        else
                            Console.WriteLine("Pila 2 Vacia no se puede sacar disco");
                        break;

                    case 3:
                        if (!Pila3.pila_vacia())
                            disco = Pila3.suprimir();
                        else
                            Console.WriteLine("Pila 3 Vacia no se puede sacar disco");
                        break;
                }
                if (disco != 0)// verifica que se saco el disco sino saltea la parte de colocar
                {
                    Console.WriteLine("Ingrese pila donde poner disco");
                    pp = int.Parse(Console.ReadLine());
                    switch (pp)
                    {
                        case 1:
                            if (Pila1.pila_vacia())
                                Pila1.insertar(disco);
                            else
                            {
                                if (disco < Pila1.pila_tope())
                                    Pila1.insertar(disco);
                                else
                                {
                                    Console.WriteLine("Pila 1  no se puede poner  disco, es demasido grande ");
                                    restaurar(ps, disco);
                                }
                            }
                            break;
                        case 2:
                            if (Pila2.pila_vacia())
                                Pila2.insertar(disco);
                            else
                            {
                                if (disco < Pila2.pila_tope())
                                    Pila2.insertar(disco);
                                else
                                {
                                    Console.WriteLine("Pila 2  no se puede poner  disco, es demasido grande ");
                                    restaurar(ps, disco);
                                }

                            }
                            break;
                        case 3:
                            if (Pila3.pila_vacia())
                                Pila3.insertar(disco);
                            else
                            {
                                if (disco < Pila3.pila_tope())
                                    Pila3.insertar(disco);
                                else
                                {
                                    Console.WriteLine("Pila 3  no se puede poner  disco, es demasido grande ");
                                    restaurar(ps, disco);
                                }
                            }
                            break;

                    }

                    if (ps != pp) //si se produce traslado de pilas distintas entonces cuenta el  movimiento
                        cm++;

                }
                disco = 0;
                Console.ReadLine();
            }

            Console.WriteLine("Felicitaciones !!!! , lo resolvio en  {0} movimentos ", cm);
            Console.WriteLine("Cantidad de movimentos optimos para  {0} discos es : {1}", tamP, Math.Pow(2, tamP) - 1);

            Console.ReadLine();
        }
    }
}
