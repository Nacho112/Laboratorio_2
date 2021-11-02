using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIntegrador
{
    class Camisa
    {
        int precioBase;
        bool mangaCorta;
        bool calStandard;

        public Camisa(int precioBase, bool mangaCorta, bool calStandard)
        {
            this.precioBase = precioBase;
            this.mangaCorta = mangaCorta;
            this.calStandard = calStandard;
        }

        public double PrecioFinal()
        {
            double precio = precioBase;

            if (mangaCorta)
            {
                precio -= (precio * 0.10);
            }

            if (! calStandard)
            {
                precio += (precio * 0.30);
            }

            return precio;
        }
    }
}