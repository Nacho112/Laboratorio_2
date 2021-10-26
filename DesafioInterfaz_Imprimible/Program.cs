using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaz_Imprimible
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato miContrato = new Contrato();
            Foto miFoto = new Foto();
            Documento miDocumento = new Documento();
            Impresora miImpresora = new Impresora();

            miImpresora.AgregarImprimible(miContrato);
            miImpresora.AgregarImprimible(miFoto);
            miImpresora.AgregarImprimible(miDocumento);

            miImpresora.ImprimirTodo();

            Console.ReadKey();
        }
    }
}