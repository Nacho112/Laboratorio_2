using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Escopeta : Armas
    {
        public Escopeta()
        {
            _nombre = "ESCOPETA";
        }

        public override void Disparar()
        {
            Console.WriteLine("¡Paaa!");
        }
    }
}