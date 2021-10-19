using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    public class Soldado
    {
        private Armas _arma;
        private int _mano;
        
        public Soldado()
        {
            _mano = 0;
        }

        public void AgarrarArma(Armas arma)
        {
            if(_mano == 0)
            {
                Console.WriteLine("Agarraste un arma: " ,arma.GetNombre());
                _arma = arma;
                _mano = 1;
            }
            else{
                Console.WriteLine("Ya tienes un arma en la mano: " ,arma.GetNombre());
            }
        }

        public void DejarArma()
        {
            if(_mano == 1)
            {
                Console.WriteLine("Usted dejo " ,_arma.GetNombre() ," en el piso");
                _mano = 0;
            }
            else {
                Console.WriteLine("No tiene ningun arma en mano");
            }
        }

        public void Disparar()
        {
            if(_mano == 0)
            {
                Console.WriteLine("No tiene un arma para disparar");
            }
            else {
                Console.WriteLine("Disparo " ,_arma.GetNombre());
                _arma.Disparar();
            }
        }

        public void Arma()
        {
            if(_mano == 0)
            {
                Console.WriteLine("No tiene un arma equipada");
            }
            else {
                Console.WriteLine("Arma equipada: " ,_arma.GetNombre());   
            }
        }
    }
}