using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            int x = 0;
            pila p = new pila(6);


            Console.WriteLine("Pila creada");

            p.mostrar();
            p.insertar(3);
            p.insertar(2);

            p.mostrar();

            x = p.suprimir();
            Console.WriteLine(" Elemento  suprimido " + x);

            x = p.suprimir();
            Console.WriteLine(" Elemento  suprimido " + x);

            x = p.suprimir();
            Console.WriteLine(" Elemento  suprimido " + x);
            Console.ReadLine();

            pilalista pl = new pilalista();
            int dato = 0;


            // Console.Clear();

            do
            {
                op = M.menu();
                switch (op)
                {
                    case 'a': Console.Write("Ingrese numero a la pila : ");
                        dato = int.Parse(Console.ReadLine());
                        pl.insertar_lista(dato);
                        Console.ReadLine();
                        break;
                    case 'b': dato = pl.suprimir_lista();
                        Console.WriteLine("El elemento {0} fue eliminado", dato);
                        Console.ReadLine();
                        break;
                    case 'c': pl.mostrar_lista();
                        Console.ReadLine();
                        break;
                    case 'd':
                        Console.ReadLine();
                        break;
                    case 'e':

                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta ..intente otra vez ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }


            }
            while (op != 'e');

            string str;

            Console.WriteLine("Ingrese una cadena de caracteres");
            str = Console.ReadLine();
            char[] arr;

            arr = str.ToCharArray();

            //Console.Write("The letters in '{0}' are: '", str);
            //Console.Write(arr);
            //Console.WriteLine("Each letter in '{0}' is:", str);

            //foreach (char c in arr)
            //    Console.WriteLine(c);

            int largo = arr.Length;
            //Console.WriteLine("Cantidoda de elementos de arre: " + largo);
            pila post = new pila(10);
            int opA, opB;

            for (int i = 0; i < largo; i++)
            {
                if (char.IsDigit(arr[i]))
                    post.insertar(Convert.ToInt32(char.GetNumericValue(arr[i])));
                else
                {
                    opA = post.suprimir();
                    opB = post.suprimir();
                    switch (arr[i])
                    {
                        case '+': post.insertar(opA + opB);
                            break;
                        case '-': post.insertar(opB - opA);
                            break;
                        case '*': post.insertar(opA * opB);
                            break;
                        case '/': post.insertar(opB / opA);
                            break;


                    }
                }
            }

            post.mostrar();
            Console.ReadLine();

            //Console.WriteLine("Ingrese el tamaño de la pila A");
            //int tam = Convert.ToInt16(Console.ReadLine());
            //pila PilaA = new pila(tam);
            //Console.WriteLine("Ingrese el tamaño de la pila B");
            //tam = Convert.ToInt16(Console.ReadLine());
            //pila PilaB = new pila(tam);

            Console.WriteLine("Ingrese cantidad de Discos");
            int tamP = int.Parse(Console.ReadLine());
            pila Pila1 = new pila(tamP);
            pila Pila2 = new pila(tamP);
            pila Pila3 = new pila(tamP);

            void restaurar (int xp,int d)
              
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
            int disco=0;
            int cm = 0;
            while (!Pila3.pila_llena())
            {
                Console.Clear();
                Console.WriteLine("Ingrese pila donde sacar disco");
                ps = int.Parse(Console.ReadLine());
                switch (ps)
                {
                    case 1: if (!Pila1.pila_vacia())
                                disco = Pila1.suprimir();
                            else
                                Console.WriteLine("Pila 1 Vacia no se puede sacar disco");
                            break;

                    case 2: if (!Pila2.pila_vacia()) 
                                disco = Pila2.suprimir();
                            else
                                Console.WriteLine("Pila 2 Vacia no se puede sacar disco");
                            break;

                    case 3: if (!Pila3.pila_vacia()) 
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
                        case 1: if (Pila1.pila_vacia())
                                    Pila1.insertar(disco);
                                else
                                {
                                    if (disco<Pila1.pila_tope())
                                        Pila1.insertar(disco);
                                    else
                                    {
                                        Console.WriteLine("Pila 1  no se puede poner  disco, es demasido grande ");
                                        restaurar(ps, disco);
                                    }
                                }
                                break;
                        case 2: if (Pila2.pila_vacia())
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
                        case 3: if (Pila3.pila_vacia())
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
                Console.Clear();
                Pila1.mostrar();
               Console.SetCursorPosition(15,0);
                Pila2.mostrar();
               Console.SetCursorPosition(30, 0);
                Pila3.mostrar();
                Console.ReadLine();

            }

            Console.WriteLine("Felicitaciones !!!! , lo resolvio en  {0} movimentos ", cm);
            Console.WriteLine("Cantidad de movimentos optimos para  {0} discos es : {1}", tamP, Math.Pow(2, tamP) - 1);

            Console.ReadLine();



            Console.WriteLine("Ingrese el tamaño de la Serie de Fibonacci");
            int tam = int.Parse(Console.ReadLine());
            pila serie = new pila(tam);
            int unoantes = 1, dosantes = 0, actual; 
            
            serie.insertar(dosantes);
            serie.insertar(unoantes);

            for (int i =2; i < tam; i++)
            {
                actual = unoantes + dosantes;
                serie.insertar(actual);
                dosantes = unoantes;
                unoantes = actual;
            }

            serie.mostrar();

            int total = 0;
            for (int i=0;i<tam;i++)
            {
                total += serie.suprimir();
            }

            Console.WriteLine("Total de la serie para : {0} componentes = {1} ", tam, total);

            Console.ReadLine();
            



            Console.WriteLine("Ingrese numero para calcular binario");
            pila bin = new pila(10);
            int entero = int.Parse(Console.ReadLine());
            int cociente = entero;
            int modulo = 0;
            while (cociente >1)
            {
                modulo = cociente % 2;
                cociente = cociente / 2;
                bin.insertar(modulo);
            }
            if (cociente == 1)
                bin.insertar(cociente);
            bin.mostrar();

            

            Console.Write("\n\nPress any key to continue . . . ");
            Console.ReadKey(true);


        }

        
    }
}
