using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sc = new Random();

            int datoIngresado, aleatorio;
            int intentos = 3;

            aleatorio = sc.Next(1, 100);

            Console.WriteLine("");
            Console.WriteLine("                                         --- Adivina el numero!!! ---");
            Console.WriteLine("");

            Console.WriteLine("Tienes {0} intentos permitidos" ,intentos);

            do
            {
                Console.WriteLine("Ingrese algun numero");
                datoIngresado = Convert.ToInt32(Console.ReadLine());

                if (datoIngresado == aleatorio)
                {
                    Console.WriteLine("Adivinaste, Muy Bien !!!");
                }

                else
                {
                    intentos -= 1;

                    Console.WriteLine("");

                    Console.WriteLine("Incorrecto, Te quedan " + intentos + " intentos");

                    if (datoIngresado > aleatorio)
                    {
                        Console.WriteLine("Proba con uno mas chico");
                    }

                    if (datoIngresado < aleatorio)
                    {
                        Console.WriteLine("Proba con uno mas grande");
                    }

                    if (intentos == 0)
                    {
                        Console.WriteLine("");

                        Console.WriteLine("Perdiste");
                        Console.WriteLine("Te quedaste sin intentos");
                        Console.WriteLine("La respuesta era: " + aleatorio);
                    }
                }

            } while (datoIngresado != aleatorio && intentos != 0);
                
            Console.ReadKey();
        }
    }
}
