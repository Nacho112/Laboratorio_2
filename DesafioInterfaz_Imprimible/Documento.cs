using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaz_Imprimible
{
    class Documento : IImprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un documento de  Word");
        }
    }
}