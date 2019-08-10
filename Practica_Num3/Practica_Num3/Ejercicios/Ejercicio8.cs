using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Num3.Ejercicios
{
    class Ejercicio8
    {
        static void Main(string[] args)
        {
            //Variables
            decimal precioProducto;
            string nombreProducto;
            decimal descuentoColor;
            Random numeroRandom = new Random();

            //Proceso: Obtener datos
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----Sistema de ventas-----");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Escriba el nombre del producto: ");
            nombreProducto = Console.ReadLine();
            Console.Write("Precio del producto: $");
            precioProducto = Convert.ToDecimal(Console.ReadLine());

            //Rifa: 
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---Se ha ingresado un nuevo producto con exito---");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nNombre del producto: {0}", nombreProducto);
            Console.WriteLine("Precio del producto: {0}", precioProducto);
            Console.WriteLine("\nHa ingresado a una nueva rifa: Dependiendo del color que le salga tendra un descuento en su compra");

            //Ruelta or someshit
            Console.Write("\nObteniendo bolita");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");

            Console.Write("\nColor Resultante: ");
            int colores = numeroRandom.Next(1, 5);
            
            switch (colores)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(100);
                Console.Write("Blanco");
                    Console.WriteLine("\nNo recibe descuento por su compra, siga comprando para participar ;)");
                    Console.WriteLine("Precio Final: ${0}", precioProducto);
                    break;

                case 2:
                 Console.ForegroundColor = ConsoleColor.Green;
                    System.Threading.Thread.Sleep(100);
                    Console.Write("Verde");
                    Console.WriteLine("\nRecibe un 15% de descuento en su compra");
                    descuentoColor = precioProducto * 0.15m;
                    Console.WriteLine("Precio Final: ${0}", (precioProducto - descuentoColor));
                    break;


                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Threading.Thread.Sleep(100);
                    Console.Write("Amarillo");
                    Console.WriteLine("\nRecibe un 18% de descuento en su compra");
                    descuentoColor = precioProducto * 0.18m;
                    Console.WriteLine("Precio Final: ${0}", (precioProducto - descuentoColor));
                    break;


                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Threading.Thread.Sleep(100);
                    Console.Write("Azul");
                    Console.WriteLine("\nRecibe un 20% de descuento en su compra");
                    descuentoColor = precioProducto * 0.20m;
                    Console.WriteLine("Precio Final: ${0}", (precioProducto - descuentoColor));
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Threading.Thread.Sleep(100);
                    Console.Write("Roja");
                    Console.WriteLine("\nRecibe un 25% de descuento en su compra");
                    descuentoColor = precioProducto * 0.25m;
                    Console.WriteLine("Precio Final: ${0}", (precioProducto - descuentoColor));
                    break;
            }

            Console.ReadLine();
         


            
            
        }
    }
}
