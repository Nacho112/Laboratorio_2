using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int miliseg = DateTime.Now.Millisecond;
            int numero = miliseg % 100 + 1;

            Console.WriteLine("Numero aleatorio entre 1 y 100: {0}" ,numero);

            Console.ReadKey();
        }
    }
}
