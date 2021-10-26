using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaz_Volador
{
    class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl miTorre = new TorreDeControl();
            Boeing747 miAvion = new Boeing747();
            Superman miSuperheroe = new Superman();
            Pato miPato = new Pato();

            miTorre.agregarVolador(miPato);
            miTorre.agregarVolador(miAvion);
            miTorre.agregarVolador(miSuperheroe);
            

            miTorre.vuelenTodos();
            Console.ReadKey();
        }
    }
}