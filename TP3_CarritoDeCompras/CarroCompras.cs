using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class CarroCompras
    {
        private int cantidad;
        private double total;
        private double descuento;
        private double totalFinal;

        public CarroCompras()
        {
            Cantidad = 0;
        }

        public void calculoTotal(double price)
        {
            Total = Cantidad * price;
        }

        public void aplicarDescuento()
        {
            if (Cantidad >= 3 && Cantidad <= 5)
            {
                Descuento = 0.1;
            }
            else if (Cantidad > 5)
            {
                Descuento = 0.2;
            }
            else
            {
                Descuento = 0.0;
            }

            totalFinal = total - total * descuento;
        }

        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }

        public double Total
        {
            get => total;
            set => total = value;
        }

        public double Descuento
        {
            get => descuento;
            set => descuento = value;
        }

        public double TotalFinal
        {
            get => totalFinal;
            set => totalFinal = value;
        }
    }
}
