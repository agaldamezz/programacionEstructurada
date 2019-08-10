using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Num3.Ejercicios
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            //Variable
            int numero;
            //Proceso de obtener numero
            Console.Write("Escriba un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("Uno");
            }
            if (numero == 2)
            {
                Console.WriteLine("Dos");
            }
            if (numero == 3)
            {
                Console.WriteLine("Tres");
            }
            if (numero == 4)
            {
                Console.WriteLine("Cuatro");

            }
            if (numero == 5)
            {
                Console.WriteLine("Cinco");
            }
            if (numero == 6)
            {
                Console.WriteLine("Seis");
            }
            if (numero == 7)
            {
                Console.WriteLine("Siete");
            }
            if (numero == 8)
            {
                Console.WriteLine("Ocho");
            }

            if (numero >= 11)
            {
                Console.WriteLine("Numero no valido.");
            }
            Console.ReadLine();
        }
    }
}
