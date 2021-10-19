using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Rifle : Armas
    {
        public Rifle()
        {
            _nombre = "RIFLE";
        }

        public override void Disparar()
        {
            Console.WriteLine("Pum Pum Pum...");
        }
    }
}