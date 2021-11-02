using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Television : Electrodomesticos
    {
        private int resolucion;
        private bool sintonizacionTDT;

        public Television()
        {

        }

        public Television(int resolucion, bool sintonizacionTDT)
        {
            this.resolucion = 20;
            this.sintonizacionTDT = false;
        }

        public Television(double precioBase, int peso) : base(precioBase, peso)
        {

        }

        public Television(double precioBase, string color, string consumoElectrico, int peso) : base(precioBase, color, consumoElectrico, peso)
        {

        }

        public int Resolucion { get => resolucion; set => resolucion = value; }
        public bool SintonizacionTDT { get => sintonizacionTDT; set => sintonizacionTDT = value; }

        public void PrecioFinal()
        {
            int sintonizador;

            base.precioFinal();

            Console.WriteLine("Digite la Resolucion");
            resolucion = Convert.ToInt32(Console.ReadLine();

            Console.WriteLine("1) Si");
            Console.WriteLine("2) No");
            Console.WriteLine("Posee Sintonizador?");
            sintonizador = Convert.ToInt32(Console.ReadLine());

            if (resolucion > 40)
            {
                PrecioBase = (PrecioBase * 1.30);
            }

            if (sintonizador == 1)
            {
                sintonizacionTDT = true;

                if (sintonizacionTDT == true)
                {
                    PrecioBase = (PrecioBase * 1.50);
                }
            }
            else
            {
                sintonizacionTDT = false;
            }

            Console.WriteLine("Consumo Electrico: " + ConsumoElectrico);
            Console.WriteLine("Precio Base: " + PrecioBase);
        }
    }
}