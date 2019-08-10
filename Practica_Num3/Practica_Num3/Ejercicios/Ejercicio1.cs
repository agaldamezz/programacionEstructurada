using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Num3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables
            int horas;
            float minutos;
            float segundos;

            //Proceso
            Console.WriteLine("Sistema de Conversion: Horas a minutos y a segundos.");
            Console.Write("Escriba el numero de horas a convertir: ");
            horas = Convert.ToInt32(Console.ReadLine());

            if (horas < 0)
            {
                Console.ReadKey();


            }

            else
            {
                minutos = horas * 60;
                Console.WriteLine("Minutos: {0}", minutos);
                segundos = minutos * 60;
                Console.WriteLine("Segundos: {0}", segundos);

                Console.WriteLine("Presione [ENTER] para continuar");
                Console.ReadKey();

            }
        }
    }
}


