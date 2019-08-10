using System;


namespace Practica_Num1.Ejercicios
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            //variables 
            string numeroAgregado = "Numero agregado: ";
            decimal num1;
            decimal num2;
            decimal respuestaSuma;
            decimal respuestaResta;
            decimal respuestaMultiplicacion;
            decimal respuestaDivision;

            //Proceso: Obtener datos
            Console.Write("Primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("{0} {1}\n", numeroAgregado, num1);
            Console.Write("Segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("{0} {1}", numeroAgregado, num2);
            Console.WriteLine("[Enter] para continuar");
            Console.ReadKey();


            //Proceso: Matematico
            respuestaSuma = num1 + num2;
            respuestaResta = num1 - num2;
            respuestaMultiplicacion = num1 * num2;
            respuestaDivision = num1 / num2;


            //Muestra: Datos en pantalla
            Console.Clear();
            Console.WriteLine("La suma de los numeros anteriores es: {0}\n", Math.Round(respuestaSuma, 1));
            Console.WriteLine("La resta de ambos numeros anteriores es: {0}\n", Math.Round(respuestaResta, 1));
            Console.WriteLine("La multiplicacion de ambos numeros es: {0}\n", Math.Round(respuestaMultiplicacion, 1));
            Console.WriteLine("La division de ambos numeros es: {0}\n", Math.Round(respuestaDivision, 1));




            Console.WriteLine("[Enter] para terminar el proceso");
            Console.ReadKey();
        }
    }
}
