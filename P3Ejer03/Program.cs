using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P3Ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
            lista l = new lista(24);
            datos d = new datos();
            string linea;
            string[] datos = new string[10]; //como son 10 atributos a separar 
            string nom1, nom2;//lee nombres de provincia para comparar cuando cambian
            float super,total=0;//leer superfice y acumularla 
            StreamReader file = new StreamReader(@"C:\Users\omar\source\repos\EstructuraDatos\P3Ejer03\superficie-afectada-por-incendios-forestales-en-el-pais.csv");
            linea = file.ReadLine();
            linea = file.ReadLine();
            datos = linea.Split(';'); //Split, recibe el carácter separador
            nom1 = datos[3];
            super = float.Parse(datos[6]);
            total = total + super;
            while ((linea = file.ReadLine()) != null)
            {
                datos = linea.Split(';'); //Split, recibe el carácter separador
                nom2 = datos[3];
                if (nom1==nom2)
                {
                    super = float.Parse(datos[6]);
                    total = total + super;
                }
                else
                {
                    d.nombre = nom1;
                    d.sup = total;
                    l.insertar_o(d);
                    nom1 = nom2;
                    total = float.Parse(datos[6]);
                }               
            }
            d.nombre = nom1;
            d.sup = total;
            l.insertar_o(d);

            file.Close();
            l.mostrar_lista();
           
            Console.ReadLine();
        }
    }
}
