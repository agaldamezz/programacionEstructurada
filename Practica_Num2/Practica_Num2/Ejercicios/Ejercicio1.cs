using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Num2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string nombre;

            //Proceso
            Console.Write("Por favor, escriba su nombre: ");
            nombre = Console.ReadLine();
            nombre = nombre.Replace('A', '#').Replace('E', '%').Replace('I', '$').Replace('O', '?').Replace('U', '*');
            nombre = nombre.Replace('a', '#').Replace('e', '%').Replace('i', '$').Replace('o', '?').Replace('u', '*');
            Console.WriteLine(nombre);
            Console.WriteLine("Presione [Enter] para continuar");
            Console.ReadKey();
        }
    }
}
