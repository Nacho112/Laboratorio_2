using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Television miTele = new Television();
            Lavadora miLavadora = new Lavadora();
            
            int opc;

            Console.WriteLine("1) Lavadora     2) Television");

            Console.WriteLine("\nSeleccione un Producto: ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    miTele.PrecioFinal();
                    break;

                case 2:
                    miLavadora.precioFinal();
                    break;

                default:
                    Console.WriteLine("Producto No Existe");
                    break;
            }

            Console.ReadKey();
        }
    }
}