using System;

namespace Practica_Num1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string nombreMascota;
            string razaMascota;
            int edadPerro;


            //Proceso de Bienvenida.
            Console.WriteLine("Base de datos de Mascota.");
            Console.WriteLine("Presione [Enter] para continuar");
            Console.ReadKey();

            //Proceso: Nombre de mascota
            Console.Clear();
            Console.WriteLine("Escriba el nombre de su mascota:");
            nombreMascota = Console.ReadLine();

            //Proceso: Especie
            Console.Clear();
            Console.WriteLine("Escriba la especie:");
            razaMascota = Console.ReadLine();


            //Proceso: Edad
            Console.Clear();
            Console.WriteLine("La edad del perro:");
            edadPerro = Convert.ToInt32(Console.ReadLine());

            //Proceso: Muestra de datos
            Console.Clear();
            Console.WriteLine("---------Muestra de datos----------");
            Console.WriteLine();
            Console.WriteLine("Nombre de la Mascota: " + nombreMascota);
            Console.WriteLine("Raza de la mascota: " + razaMascota);
            Console.WriteLine("Edad de la mascota: " + edadPerro);
            Console.ReadKey();
        }
    }
}
