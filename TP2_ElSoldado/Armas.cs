using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    abstract public class Armas
    {
        protected String _nombre;

        public abstract void Disparar();

        public String GetNombre()
        {
            return _nombre;
        }
    }
}