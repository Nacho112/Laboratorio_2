using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Lavadora : Electrodomesticos
    {
        private int carga;

        public Lavadora(int carga)
        {
            this.carga = carga;
        }

        public Lavadora(double precioBase, int peso) : base(precioBase, peso)
        {

        }

        public Lavadora(double precioBase, string color, string consumoElectrico, int peso) : base(precioBase, color, consumoElectrico, peso)
        { 

        }

        public Lavadora()
        {

        }

        public int Carga { get => carga; set => carga = value; }

        public new void precioFinal()
        {
            base.precioFinal();

            if(carga > 30)
            {
                PrecioBase += 50;
            }

            Console.WriteLine("Consumo Electrico: " + ConsumoElectrico);
            Console.WriteLine("Precio Base: " + PrecioBase);
        }
    }
}