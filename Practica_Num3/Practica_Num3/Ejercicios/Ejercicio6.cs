using System;


namespace Practica_Num3.Ejercicios
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            //Variables
            string nombreProducto;
            decimal precioProducto;
            int cantidad;
            decimal precioXcantidad;
            decimal aplicacionDescuento;


            //Proceso
            Console.WriteLine("Sistema de Descuentos");
            Console.Write("Nombre del producto: ");
            nombreProducto = Console.ReadLine();
            Console.Write("Precio del producto: $");
            precioProducto = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Cantidad de productos: ");
            cantidad = Convert.ToInt32(Console.ReadLine());


            //Proceso: Monto
            precioXcantidad = precioProducto * cantidad;


            if (precioXcantidad > 0 && precioXcantidad <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNo hay descuento");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Nombre del producto:{0}", nombreProducto);
                Console.WriteLine("Total a pagar: ${0}", precioXcantidad);
            }

            if (precioXcantidad > 100.01m && precioXcantidad <= 200)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n12% de descuento");
                Console.ForegroundColor = ConsoleColor.White;
                aplicacionDescuento = precioXcantidad * 0.12m;
                Console.WriteLine("Nombre del producto:{0}", nombreProducto);
                Console.WriteLine("Total a pagar: ${0}", precioXcantidad - aplicacionDescuento);
            }


            if (precioXcantidad > 200.01m && precioXcantidad <= 500)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n15% de descuento");
                Console.ForegroundColor = ConsoleColor.White;
                aplicacionDescuento = precioXcantidad * 0.15m;
                Console.WriteLine("Nombre del producto:{0}", nombreProducto);
                Console.WriteLine("Total a pagar: ${0}", precioXcantidad - aplicacionDescuento);
            }


            if (precioXcantidad > 500.01m)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n20% de descuento");
                Console.ForegroundColor = ConsoleColor.White;
                aplicacionDescuento = precioXcantidad * 0.20m;
                Console.WriteLine("Nombre del producto:{0}", nombreProducto);
                Console.WriteLine("Total a pagar: ${0}", precioXcantidad - aplicacionDescuento);
            }
            Console.ReadKey();
        }
    }
}
