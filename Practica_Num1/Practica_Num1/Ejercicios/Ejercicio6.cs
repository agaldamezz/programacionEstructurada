using System;


namespace Practica_Num1.Ejercicios
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            //Variables y arreglos.
            string nombre;
            string apellido;
            int sueldo;

            int afp;
            int isss;

            //Constantes:
            const double AFP = 13.74;
            const double ISSS = 33.32;
            const double RENTA = 24.75;

            //Proceso: Introducción al programa

            Console.WriteLine("Sistema de datos de empleados");
            Console.WriteLine("[Enter] para continuar");
            Console.ReadKey();
            Console.Clear();

            //Obtener datos
            Console.Write("Nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido del empleado: ");
            apellido = Console.ReadLine();
            Console.Write("Sueldo Actual: ");
            sueldo = Convert.ToInt32(Console.ReadLine());


            //Proceso: Convertir Datos
            if (sueldo >= 526)
            {
                //Si el sueldo es mayor o igual a 526 se saca la renta.


                //Sacando AFP:
                afp = Convert.ToInt32(sueldo / AFP);


                //Sacando ISSS:
                isss = Convert.ToInt32(sueldo / ISSS);

                Console.Clear();
                Console.WriteLine("Información:");
                Console.WriteLine("Nombre Completo: {0} {1}", nombre, apellido);
                Console.WriteLine("Sueldo Actual: ${0}", sueldo);
                Console.WriteLine("Descuento de AFP:${0}", afp);
                Console.WriteLine("Descuento de ISS:${0}", isss);
                Console.WriteLine("Debido a su salario, No paga renta");
                Console.WriteLine("Su sueldo restando ISSS y AFP: ${0}\n", afp + isss);
                Console.WriteLine("Presione [Enter] para continuar");
                Console.ReadKey();

            }

            if (sueldo <= 525)
            {

                //Sacando AFP:
                afp = Convert.ToInt32(sueldo / AFP);


                //Sacando ISSS:
                isss = Convert.ToInt32(sueldo / ISSS);

                Console.Clear();
                Console.WriteLine("Información:");
                Console.WriteLine("Nombre Completo: {0} {1}", nombre, apellido);
                Console.WriteLine("Sueldo Actual: ${0}", sueldo);
                Console.WriteLine("Descuento de AFP:${0}", afp);
                Console.WriteLine("Descuento de ISS:${0}", isss);
                Console.WriteLine("Debido a su salario, No paga renta");
                Console.WriteLine("Su sueldo restando ISSS y AFP: ${0}\n", afp + isss);
                Console.WriteLine("Presione [Enter] para continuar");
                Console.ReadKey();
            }
        }
    }
}
