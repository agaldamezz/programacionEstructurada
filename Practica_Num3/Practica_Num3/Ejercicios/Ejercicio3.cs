using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Num3.Ejercicios
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            //Variables
            int num1;
            int num2;
            int num3;


            //Proceso
            Console.Write("Escriba un numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escriba un numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escriba un numero: ");
            num3 = Convert.ToInt32(Console.ReadLine());


            //Mostrar datos

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine(num1);

            }

            else
            {
                if (num2 < num1 && num2 < num3)
                {
                    Console.WriteLine(num2);

                }
                else
                {
                    if (num3 < num1 && num3 < num2)
                    {
                        Console.WriteLine(num3);

                    }
                }

            }


            if (num1 > num2 && num1 < num3)
            {
                Console.WriteLine(num1);

            }

            else
            {
                if (num2 > num1 && num2 < num3)
                {
                    Console.WriteLine(num2);

                }
                else
                {
                    if (num3 > num1 && num3 < num2)
                    {
                        Console.WriteLine(num3);

                    }
                }

            }

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1);

            }

            else
            {
                if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine(num2);

                }
                else
                {
                    if (num3 > num1 && num3 > num2)
                    {
                        Console.WriteLine(num3);

                    }
                }

            }



            Console.ReadKey();
        }
    }
}
