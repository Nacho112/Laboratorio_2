using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_EJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            int aleatorio, numIngresado;
            int intento = 13;

            Random rd = new Random();
            aleatorio = rd.Next(1, 10000);

            Console.WriteLine("                                       -- Adivina Adivinador --");
            Console.WriteLine("Vas a tener: " + intento + " intentos");

            Console.WriteLine("");

            Console.WriteLine("                      ---------------------------------------------------------");

            Console.WriteLine("                                     Intenta adivinar el numero !!");

            do
            {
                Console.WriteLine("Digite algun numero");

                numIngresado = Convert.ToInt32(Console.ReadLine());

                if (numIngresado == aleatorio)
                {
                    Console.WriteLine("Felicitaciones, Adivinaste!");
                    Console.WriteLine("Te quedaron: " + intento + " intentos");
                }

                else
                {
                    intento -= 1;

                    Console.WriteLine("");
                    Console.WriteLine("Incorrecto, te quedan " + intento + " intentos");


                    if (numIngresado < aleatorio)
                    {
                        Console.WriteLine("Intente con un numero mas grande");
                    }

                    if (numIngresado > aleatorio)
                    {
                        Console.WriteLine("Intente con uno mas chico");
                    }

                    if (intento == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("                      ---------------------------------------------------------");
                        Console.WriteLine("                                  Perdiste te quedaste sin intentos");
                        Console.WriteLine("");
                        Console.WriteLine("La respuesta correcta era: " + aleatorio);
                    }
                }

                Console.WriteLine("");

            } while (numIngresado != aleatorio && intento != 0);

            Console.ReadKey();
        }   
    }
}