using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia_Inmobiliria
{
    class Local : Inmueble
    {
        public double local(double precioFinal, int años, int metrosCuadrados, int nroVentanas)
        {
            if(años < 15)
            {
                precioFinal -= precioFinal * 0.01;
            }
            else
            {
                precioFinal -= precioFinal * 0.02;
            }

            if(metrosCuadrados > 50)
            {
                precioFinal += precioFinal * 0.01;
            }

            if(nroVentanas <= 1)
            {
                precioFinal -= precioFinal * 0.02;

            }else if(nroVentanas > 4){

                precioFinal += precioFinal * 0.02;
            }

            return precioFinal;
        }
    }
}
