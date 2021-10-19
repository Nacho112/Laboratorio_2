using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class Menu
    {
        private int opcion = 0;
        private int costo = 0;

        public void MostrarMenu(Camisas miCamisas, CarroCompras miCarrito)
        {
            do
            {
                miCarrito.calculoTotal(miCamisas.GetPrecioUnitario());
                miCarrito.aplicarDescuento();

                Console.WriteLine("MENÚ PRINCIPAL:");
                Console.WriteLine("1- Añadir camisas al carro de compras.");
                Console.WriteLine("2- Eliminar camisas del carro de compras.");
                Console.WriteLine("3- Salir.");
                if (miCarrito.Cantidad > 0)
                {
                    Console.WriteLine("4- Comprar.");
                }

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("         -    Cantidad de camisas en el carro de compras: " + miCarrito.Cantidad);
                Console.WriteLine("         -    Precio unitario: " + miCamisas.GetPrecioUnitario());
                Console.WriteLine("         -    Precio total sin descuento: $" + miCarrito.Total);
                Console.WriteLine("         -    Tipo de descuento aplicado: " + (miCarrito.Descuento * 100) + "%");
                Console.WriteLine("         -    Precio final con descuento: $" + miCarrito.TotalFinal);
                Console.WriteLine("Ingrese segun corresponda: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Introduzca cantidad de camisas a añadir: ");
                            costo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Se agregaron " + costo + " camisas");
                            miCarrito.Cantidad = miCarrito.Cantidad + costo;
                            break;

                        case 2:
                            if (costo > 0)
                            {
                                Console.WriteLine("Introduzca cantidad de camisas a eliminar: ");
                                try
                                {
                                    int aux = Convert.ToInt32(Console.ReadLine());
                                    if (aux <= costo && aux > 0)
                                    {
                                        costo -= aux;
                                        miCarrito.Cantidad = costo;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nFuera de rango.");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nDebe ingresar un numero positivo.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNo hay camisas para eliminar");
                            }
                            break;

                        case 3:

                            char salir;
                            Console.WriteLine("Desea Salir? S/N");
                            try
                            {
                                salir = Convert.ToChar(Console.ReadLine()[0]);

                                if (salir == 'S')
                                {
                                    Console.WriteLine("Saliendo...");
                                    Environment.Exit(0);
                                }
                                else if (salir == 'N')
                                {
                                    opcion = 0;
                                }
                                else
                                {
                                    Console.WriteLine("\nNo se reconoció opción");
                                    opcion = 0;
                                }
                            }
                            catch (NullReferenceException)
                            {
                                Console.WriteLine("S para SI --- N para NO");
                            }
                            break;

                        case 4:
                            char realizarCompra; 
                            if (miCarrito.Cantidad != 0)
                            {
                                Console.WriteLine("Desea realizar la compra? S/N");
                                try
                                {
                                    realizarCompra = Convert.ToChar(Console.ReadLine()[0]);

                                    if (realizarCompra == 'S')
                                    {
                                        Console.WriteLine("Compra realizada con exito!");
                                        Console.WriteLine("Saliendo...");
                                        Environment.Exit(0);
                                    }
                                    else if (realizarCompra == 'N')
                                    {
                                        opcion = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se reconoció opción");
                                        opcion = 0;
                                    }
                                }
                                catch (NullReferenceException)
                                {
                                    Console.WriteLine("S para SI --- N para NO");
                                }
                            }
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Debe ingresar un numero positivo.");
                }
            } while (opcion != 3);
        }
    }
}
