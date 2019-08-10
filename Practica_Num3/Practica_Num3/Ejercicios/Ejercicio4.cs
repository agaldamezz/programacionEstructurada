using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Num3.Ejercicios
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            //Variables
            int minutos;
            int segundos;
            decimal tiempoLlamada;
            decimal segundosAgregados;
            decimal precioLlamada;

            int zonaElegir;

            //Proceso
            Console.WriteLine("Sistema de cobros de llamada:");
            Console.WriteLine("Escriba la duración de la llamada");
            Console.Write("Minutos: ");
            minutos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundos: ");
            segundos = Convert.ToInt32(Console.ReadLine());

            //Conversion
            segundosAgregados = segundos * .1m;
            tiempoLlamada = minutos + segundosAgregados;

            //Elegir Zona:
            Console.WriteLine("\nElija la zona donde se ha hecho la llamada");
            Console.WriteLine("[1]Zona Occidental");
            Console.WriteLine("[2]Zona central");
            Console.WriteLine("[3]Zona Oriental");
            zonaElegir = Convert.ToInt32(Console.ReadLine());


            //Proceso: Pago por zonas
            if (zonaElegir == 1)
            {
                precioLlamada = tiempoLlamada * 0.32m;
                Console.WriteLine("\nPrecio a pagar: ${0}", Math.Truncate(precioLlamada * 100) / 100);
                Console.ReadLine();


            }

            if (zonaElegir == 2)
            {
                precioLlamada = tiempoLlamada * 0.25m;
                Console.WriteLine("\nPrecio a pagar: ${0}", Math.Truncate(precioLlamada * 100) / 100);
                Console.ReadLine();


            }

            if (zonaElegir == 3)
            {
                precioLlamada = tiempoLlamada * 0.36m;
                Console.WriteLine("\nPrecio a pagar: ${0}", Math.Truncate(precioLlamada * 100) / 100);
                Console.ReadLine();

            }
        }
    }
}
