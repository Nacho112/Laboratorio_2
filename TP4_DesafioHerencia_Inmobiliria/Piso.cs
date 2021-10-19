using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia_Inmobiliria
{
    class Piso : Inmueble
    {
        public double ingresarPiso(double precioFinal, int nroPiso, int años)
        {
            if(años < 15)
            {
                precioFinal -= precioFinal * 0.01;
            }
            else
            {
                precioFinal -= precioFinal * 0.02;
            }

            if(nroPiso >= 3)
            {
                precioFinal += precioFinal * 0.03;
            }

            return precioFinal;
        }
    }
}