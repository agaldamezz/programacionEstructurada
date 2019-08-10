using System;


namespace Practica_Num1.Ejercicios
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            //Variables
            double numIngresado;
            string confirmar;

            //Proceso: Obtener datos
            Console.Write("Escriba un numero entero positivo: ");
            numIngresado = Convert.ToInt32(Console.ReadLine());

            //Proceso: Matematico
            Console.WriteLine("La raiz de su numero es: {0}\n", Math.Sqrt(numIngresado));
            Console.WriteLine("Le gustaria se numero sin decimales? (Y/N)");
            confirmar = Console.ReadLine();
            if (confirmar == "Y")
            {
                Console.WriteLine("Su numero es: {0}", Math.Round(Math.Sqrt(numIngresado)));
            }


            if (confirmar == "y")
            {

                Console.WriteLine("Su numero es: {0}", Math.Round(Math.Sqrt(numIngresado)));
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Ok");
                Console.ReadKey();
            }
        }
    }
}
