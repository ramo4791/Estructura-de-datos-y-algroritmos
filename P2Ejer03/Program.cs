using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
            ////            Ejercicio Nº 3
            ////(a + t) * (b + (a / c))f Notación infija
            ////at + bac / +*Notación postfija
            ///ejemplo 
            ///es equivalanete a (a+2)*(4+(6/3)) = 48
            ///
            ////  Una expresión en notación postfija puede ser evaluada haciendo un recorrido de izquierda a derecha.
            ////Cuando se encuentra un operando, se apila en una pila de operandos.Cuando se encuentra un operador, 
            //se desapilan dos operandos de la pila, se realiza la correspondiente operación y el resultado se apila 
            //    en la pila de operandos.
            ////Diseñe un programa que evalúe una expresión en notación postfija y muestre el resultado.

            string str;

            Console.WriteLine("Ingrese una cadena de caracteres");
            str = Console.ReadLine();
            char[] arr;

            arr = str.ToCharArray();

         

            int largo = arr.Length;
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
                        case '+':
                            post.insertar(opA + opB);
                            break;
                        case '-':
                            post.insertar(opB - opA);
                            break;
                        case '*':
                            post.insertar(opA * opB);
                            break;
                        case '/':
                            post.insertar(opB / opA);
                            break;


                    }
                }
            }

            post.mostrar();
            Console.ReadLine();

        }
    }
}
