using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaz_Imprimible
{
    class Impresora
    {
        List<IImprimible> colaDeImpresion = new List<IImprimible>();

        public void ImprimirTodo()
        {
            foreach(IImprimible x in colaDeImpresion)
            {
                x.Imprimir();
            }
        }

        public void AgregarImprimible(IImprimible imprimibleUno)
        {
            colaDeImpresion.Add(imprimibleUno);
        }
    }
}