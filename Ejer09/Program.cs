using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer09
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola ct = new Cola(40);//cola turnos
            Cola cp = new Cola(15);//cola peluqueria
            Cola cb = new Cola(15);//cola barberia
            Cola cc = new Cola(15);//cola cama solar
            bool todas_vacias;

            double tiempo_rec = 2;//tiempo promedio de atencion en recepcion
            double prob_aten;//la problabilidad de atencion en un minuto es de 1/2
            prob_aten = (1 / tiempo_rec) * 100;
            int tiempo_esp = 15;//tiempo promedio del especialista
        

            int cant_pelu=0, cant_barb=0, cant_cs=0;
            int total_cp=0, total_cb=0, total_cc=0;
            int prome_cp, prome_cb, prome_cc;
            int reloj = 0;
            Random rdn = new Random();
            int ts;
            Console.WriteLine("Ingrese tiempo de simulacion en minutos :");
            ts = int.Parse(Console.ReadLine());
            Console.Clear();
            int random;
            int tiemrecep = 60;
            int atendiendo_pelu=15, atendiendo_bar=15, atendiendo_cs=15;

            int cant_atend=0,total_ct = 0, prome_ct;//tiempo total de espera en cola sobre cantidad de atendidos es el promedio
            bool nuevoturno = false;

            do
            {

                if (reloj < tiemrecep)
                {
                    ct.insertar(reloj);

                    random = rdn.Next(101);
                    if (random < prob_aten)
                    {
                        if (!ct.vacia())
                        {
                            total_ct = (reloj - ct.suprimir()) + total_ct;//quiza falta sumar tiempo atencion
                            cant_atend++;
                            nuevoturno = true;
                        }
                    }
                }
                if (nuevoturno)
                {
                    random = rdn.Next(101);
                    if (random <= 33)
                    {
                        if (cant_pelu < 15)
                        {
                            cp.insertar(reloj);
                        }
                        else
                            Console.WriteLine("No se pueden tomar mas turnos en peluqueria");
                    }
                    else
                    {
                        if (random > 33 && random <= 66)
                        {
                            if (cant_barb < 15)
                            {
                                cb.insertar(reloj);
                            }
                            else
                                Console.WriteLine("No se pueden tomar mas turnos en barberia");

                        }
                        else
                        {
                            if (cant_cs < 15)
                            {
                                cc.insertar(reloj);
                            }
                            else
                                Console.WriteLine("No se pueden tomar mas turnos en Cama Solar");
                        }
                    }
                }
                //suprimir de cola de peluqueria

                if (atendiendo_pelu == tiempo_esp)
                {
                    if (!cp.vacia())
                    {
                        total_cp = (reloj - cp.suprimir()) + total_cp;
                        cant_pelu++;
                        atendiendo_pelu = 0;
                    }
                }
                if (atendiendo_pelu < tiempo_esp)
                {
                    atendiendo_pelu++;
                }
                //suprimir de cola de barberia

                if (atendiendo_bar == tiempo_esp)
                {
                    if (!cb.vacia())
                    {
                        total_cb = (reloj - cb.suprimir()) + total_cb;
                        cant_barb++;

                        atendiendo_bar = 0;
                    }
                }
                if (atendiendo_bar < tiempo_esp)
                {
                    atendiendo_bar++;
                }
                //suprimir cola de cama solar

                if (atendiendo_cs == tiempo_esp)
                {
                    if (!cc.vacia())
                    {
                        total_cc = (reloj - cc.suprimir()) + total_cc;
                        cant_cs++;

                        atendiendo_cs = 0;
                    }
                }
                if (atendiendo_cs < tiempo_esp)
                {
                    atendiendo_cs++;
                }

                reloj++;
                nuevoturno = false;

                if (reloj < 60)
                    todas_vacias = false;
                else
                    todas_vacias = cp.vacia() && cb.vacia() && cc.vacia();
            }

            while ((reloj < 240) && !todas_vacias);
            //while (reloj < 240) ;

            if (reloj < 240)
                Console.WriteLine("Se termino la simulacion a los {0} minutos ", reloj);
            if (cant_atend>0)
            {
                prome_ct = total_ct / cant_atend;
                Console.WriteLine("Tiempo promedio  de espera de los "+ cant_atend +" clientes :  " + prome_ct );
            }
            Console.WriteLine("Cantidad de clientes en que faltan atender :  " + ct.cantidad());
            if (cant_pelu > 0)
            {
               prome_cp = total_cp / cant_pelu;
                Console.WriteLine("Tiempo promedio  de espera de los " + cant_pelu + " clientes en peluqueria:  " + prome_cp);
            }
            if (cant_barb > 0)
            {
                prome_cb = total_cb / cant_barb;
                Console.WriteLine("Tiempo promedio  de espera de los " + cant_barb + " clientes en barberia :  " + prome_cb);
            }
            if (cant_cs > 0)
            {
                prome_cc = total_cc / cant_cs;
                Console.WriteLine("Tiempo promedio  de espera de los " + cant_cs + " clientes en cama solar:  " + prome_cc);
            }

            Console.ReadLine();
        }
    }
}
