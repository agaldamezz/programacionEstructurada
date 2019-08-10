using System;


namespace Practica_Num2.Ejercicios
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            //Variables
            string nombreProducto;
            int cantidad;
            decimal precioIncial;
            decimal subtotal;
            decimal ivaAgregado;
            decimal totalPagar;
            

          
            //Proceso
            Console.WriteLine("-----Productos-----");
            Console.Write("Escriba el nombre del producto: ");
            nombreProducto = Console.ReadLine();
            Console.Write("Precio del producto: $");
            precioIncial = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Cantidad: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            //Convirtiendo datos:
            subtotal = precioIncial * cantidad;
            ivaAgregado = subtotal * 0.13m;
            totalPagar = subtotal + ivaAgregado;

            //Muestra de datos
            Console.Clear();
            Console.WriteLine("Nombre del producto: {0}", nombreProducto);
            Console.WriteLine("Precio del producto: ${0}", precioIncial);
            Console.WriteLine("Cantidad: {0}", cantidad);
            Console.WriteLine("Subtotal: ${0}", subtotal);
            Console.WriteLine("IVA: ${0}", ivaAgregado);
            Console.WriteLine("Total a pagar: ${0}", totalPagar);
            Console.ReadKey();
        
        }
    }
}
