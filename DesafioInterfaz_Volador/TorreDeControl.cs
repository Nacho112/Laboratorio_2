using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaz_Volador
{
    class TorreDeControl
    {
        List<IVolador> listaVolador = new List<IVolador>();

        public void vuelenTodos()
        {
            foreach (IVolador x in listaVolador)
            {
                x.volador();
            }
        }

        public void agregarVolador(IVolador unVolable)
        {
            listaVolador.Add(unVolable);
        }
    }
}
