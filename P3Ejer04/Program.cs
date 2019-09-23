using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace P3Ejer04
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;
            string[] datos = new string[6]; //como son 10 atributos a separar 
            string nom1, nom2;//lee nombres de provincia para comparar cuando cambian
            float super, total = 0;//leer superfice y acumularla 
            StreamReader file = new StreamReader(@"C:\Users\omar\source\repos\EstructuraDatos\P3Ejer03\estadistica-designacion-magistrados-federal-nacional-por-genero.csv");
            linea = file.ReadLine();
            linea = file.ReadLine();
            datos = linea.Split(','); //Split, recibe el carácter separador
            datos[1]=datos[1].Trim(new char[] { '"' });
            datos[2]=datos[2].Trim(new char[] { '"' });
            datos[3]=datos[3].Trim(new char[] { '"' });
            Console.ReadLine();
        }
    }
}
