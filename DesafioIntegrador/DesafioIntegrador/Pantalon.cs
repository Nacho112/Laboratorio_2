using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIntegrador
{
    class Pantalon
    {
        bool bermuda;
        bool calStandard;
        double precioBase;

        public Pantalon(bool bermuda, bool calStandard, double precioBase)
        {
            this.bermuda = bermuda;
            this.calStandard = calStandard;
            this.precioBase = precioBase;
        }

        public double PrecioFinal()
        {
            double precio = precioBase;

            if (bermuda)
            {
                precio -= (precio * 0.30);
            }

            if (! calStandard)
            {
                precio += (precio * 0.30);
            }

            return precio;
        }
    }
}