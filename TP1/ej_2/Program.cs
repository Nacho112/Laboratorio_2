using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num1 = new Random();
            Random num2 = new Random();

            int aleat_1 = num1.Next(1, 10);
            int aleat_2 = num2.Next(11, 20);

            Console.WriteLine("Numero aleatorio 1: {0} " ,aleat_1);
            Console.WriteLine("Numero aleatorio 2: {0} " ,aleat_2);

            Console.ReadKey();
        }
    }
}