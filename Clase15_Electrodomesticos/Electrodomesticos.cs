using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    abstract class Electrodomesticos
    {
        private double precioBase;
        private string color;
        private string consumoElectrico;
        private int peso;

        protected Electrodomesticos(double precioBase, string color, string consumoElectrico, int peso)
        {
            this.precioBase = precioBase;
            comprobarColor(color);
            comprobarConsumoElectrico(consumoElectrico);
            this.peso = peso;
        }

        protected Electrodomesticos(double precioBase, int peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }

        protected Electrodomesticos()
        {

        }

        protected double PrecioBase { get => precioBase; set => precioBase = value; }
        protected string Color { get => color; set => color = value; }
        protected string ConsumoElectrico { get => consumoElectrico; set => consumoElectrico = value; }
        protected int Peso { get => peso; set => peso = value; }

        void comprobarConsumoElectrico(string letra)
        {
            if(letra != "A" && letra != "B" && letra != "C" && letra != "D" && letra != "E" && letra != "F")
            {
                letra = "F";
            }
            else
            {
                this.consumoElectrico = letra;
            }

            Console.WriteLine("Consumo Electrico: " + letra);
        }

        void comprobarColor(string color)
        {
            int opc;

            Console.WriteLine("1) Blanco");
            Console.WriteLine("2) Negro");
            Console.WriteLine("3) Rojo");
            Console.WriteLine("4) Azul");
            Console.WriteLine("5) Gris");

            Console.WriteLine("Digite el numero del color que desee: ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1: color = "Blanco"; break;
                case 2: color = "Negro"; break;
                case 3: color = "Rojo"; break;
                case 4: color = "Azul"; break;
                case 5: color = "Gris"; break;

                default:
                    Console.WriteLine("Digito Fuera de Rango");
                    break;
            }

            Console.WriteLine("Color del Electrodomestico: " + color);
        }

        public void precioFinal()
        {
            Console.WriteLine("Ingrese Consumo Energetico A - F");
            consumoElectrico = Console.ReadLine();

            double precio = 0;

            switch (consumoElectrico)
            {
                case "A": precioBase += 100; break;
                case "B": precioBase += 80; break;
                case "C": precioBase += 60; break;
                case "D": precioBase += 50; break;
                case "E": precioBase += 30; break;
                case "F": precioBase += 10; break;

                default:
                    break;
            }

            Console.WriteLine("Digite peso del Electrodomestico: ");
            peso = Convert.ToInt32(Console.ReadLine());

            if (peso > 00 && peso <= 19)
            {
                precio += 10;
            }

            if (peso > 19 && peso <= 49)
            {
                precio += 50;
            }

            if (peso > 49 && peso <= 79)
            {
                precio += 80;
            }

            if (peso >= 80)
            {
                precio += 100;
            }

            precio += precioBase;
            precioBase = precio;
        }
    }
}