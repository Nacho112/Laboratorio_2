using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    public class Revolver : Armas
    {
        
        public Revolver()
        {
            _nombre = "REVOLVER";
        }

        public override void Disparar()
        {
            Console.WriteLine("Pum...");
        }
    }
}