using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace ElSoldado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0, opcionArma;

            Soldado  miSoldado  = new Soldado();
            Revolver miRevolver = new Revolver();
            Rifle    miRifle    = new Rifle();
            Escopeta miEscopeta = new Escopeta();

            Console.WriteLine("\n\n");

            Console.WriteLine("                                          //// BIENVENDIO SOLDADO ////");

            Console.WriteLine("\n                                      Ya podemos comenzar la batalla!!!");

            Console.WriteLine("\n                         -----------------------------------------------------------------");

            do
            {
                Console.WriteLine("\n[1] RECOGER ARMA");
                Console.WriteLine("[2] DEJAR ARMA");
                Console.WriteLine("[3] DISPARAR");
                Console.WriteLine("[4] VER ARMA EN USO ");
                Console.WriteLine("[5] SALIR");

                Console.Write("\nQue accion desea realizar? ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("[1] REVOLVER");
                            Console.WriteLine("[2] RIFLE");
                            Console.WriteLine("[3] ESCOPETA");
                            Console.WriteLine("[4] VOLVER ATRAS");

                            Console.Write("Que arma deseas usar?");

                        try
                        {
                            opcionArma = Convert.ToInt32(Console.Read());

                            switch (opcionArma)
                            {
                                case 1:
                                    miSoldado.AgarrarArma(miRevolver);
                                    break;

                                case 2:
                                    miSoldado.AgarrarArma(miRifle);
                                    break;

                                case 3:
                                    miSoldado.AgarrarArma(miEscopeta);
                                    break;

                                case 4:
                                    Console.WriteLine("Cancelando Movimiento...");
                                    break;
                            }
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("//////////////////");
                        }
                            break;

                        case 2:
                            miSoldado.DejarArma();
                            break;

                        case 3:
                            miSoldado.Disparar();
                            break;

                        case 4:
                            miSoldado.Arma();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("------------------------");
                }

                if (opcion != 5) continue;

                Console.WriteLine("Saliendo...");

                Environment.Exit(0);

            } while (opcion != 5);

            Console.ReadKey();
        }
    }
}