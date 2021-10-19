using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camisas miCamisas = new Camisas();
            CarroCompras miCarrito = new CarroCompras();
            Menu miMenu = new Menu();

            Console.WriteLine("SHOPPING ONLINE DE CAMISAS - Ventas Minoristas y Mayoristas");
            Console.WriteLine("-----------------------------------------------------------");

            miMenu.MostrarMenu(miCamisas, miCarrito);

            Console.ReadKey();
        }
    }
}
