using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Num3.Ejercicios
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            //Proceso
            Random r = new Random(DateTime.Now.Millisecond);
            int nAleatorio = r.Next(100);
            Console.WriteLine(nAleatorio);


            //Par o impar

            if (nAleatorio % 2 == 0)
            {
                Console.Write("Par");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Impar");

                Console.ReadKey();
            }
            
        }
    }
}
