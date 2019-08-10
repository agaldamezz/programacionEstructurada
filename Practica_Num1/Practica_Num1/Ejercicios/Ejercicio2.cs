using System;


namespace Practica_Num1.Ejercicios
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            //Variables
            string nombre;
            string apellido;
            string cargo;
            string correo;
            int edad;
            int dia;
            int mes;
            int anio;
            string fechaContratacion;
            int sueldo;

            //Proceso: Introdccuion
            Console.WriteLine("Recolección de datos de empleados");
            Console.WriteLine("Presione [Enter] para continuar");
            Console.ReadLine();


            //Proceso: Recoleccion de datos
            Console.Clear();
            //Nombre
            Console.WriteLine("Escriba el nombre del empleado:");
            nombre = Console.ReadLine();
            Console.WriteLine();
            //Apellido
            Console.WriteLine("Apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine();
            //Cargo
            Console.WriteLine("Cargo del empleado:");
            cargo = Console.ReadLine();
            Console.WriteLine();
            //Edad
            Console.WriteLine("Edad del empleado:");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Correo
            Console.WriteLine("Correo del empleado:");
            correo = Console.ReadLine();
            Console.WriteLine();
            //Fecha
            Console.WriteLine("Fecha de Contratación");
            Console.Write("Dia:");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mes:");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Año:");
            anio = Convert.ToInt32(Console.ReadLine());
            //Sueldo
            Console.WriteLine();
            Console.WriteLine("Sueldo:");
            sueldo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPresione [Enter] para continuar");
            Console.ReadKey();
            Console.Clear();


            //Muestra de datos:
            Console.WriteLine("-----Datos del empleado-----");
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Apellido: {0}", nombre);
            Console.WriteLine("Cargo: {0}", cargo);
            Console.WriteLine("Edad: {0}", edad);
            Console.WriteLine("Correo del empleado: {0}", correo);
            Console.WriteLine("Fecha de contratación: {0}/{1}/{2}", dia, mes, anio);
            Console.WriteLine("Sueldo actual: {0}", sueldo);
            Console.WriteLine("-----Finaliza tabla-----");
            Console.ReadLine();
        }
    }
}
