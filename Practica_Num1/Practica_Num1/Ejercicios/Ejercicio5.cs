using System;

namespace Practica_Num1.Ejercicios
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            //Variables: 
            int seleccion;



            //Arreglo: Meses
            int[] meses;
            meses = new int[13];

            //Arreglo: Promedio
            int[] promedios;
            promedios = new int[5];

            //Arreglo: Resultado
            int[] resultados;
            resultados = new int[5];

            //Proceso

            do
            {
                Console.Clear();


                Console.WriteLine("Seleccione el trimestre a ingresar datos:\n");
                Console.WriteLine("[1]Primer trimestre");
                Console.WriteLine("[2]Segundo trimestre");
                Console.WriteLine("[3]Tercer trimestre");
                Console.WriteLine("[4]Cuarto trimestre");
                Console.WriteLine("[5]Mostrar promedios de ventas");
                Console.WriteLine("[6]Salir del programa");
                seleccion = Convert.ToInt32(Console.ReadLine());


                if (seleccion == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Escriba el total de ventas (Primer mes/primer trimestre)");
                    meses[1] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Segundo mes/primer trimestre)");
                    meses[2] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Tercer mes/primer trimestre)");
                    meses[3] = Convert.ToInt32(Console.ReadLine());

                    //Proceso: Sacando el promedio no.1
                    promedios[1] = meses[1] + meses[2] + meses[3];
                    resultados[1] = promedios[1] / 3;
                    Console.WriteLine("Promedio: {0}\n", resultados[1]);
                    Console.WriteLine("Escriba [7] para volver al menu");
                    seleccion = Convert.ToInt32(Console.ReadLine());

                }


                if (seleccion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Escriba el total de ventas (Primer mes/segundo trimestre)");
                    meses[4] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Segundo mes/segundo trimestre)");
                    meses[5] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Tercer mes/segundo trimestre)");
                    meses[6] = Convert.ToInt32(Console.ReadLine());

                    //Proceso: Sacando el promedio no.2
                    promedios[2] = meses[4] + meses[5] + meses[6];
                    resultados[2] = promedios[2] / 3;
                    Console.WriteLine("Promedio: {0}", resultados[2]);
                    Console.WriteLine("Escriba [7] para volver al menu");
                    seleccion = Convert.ToInt32(Console.ReadLine());


                }

                if (seleccion == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Escriba el total de ventas (Primer mes/tercer trimestre)");
                    meses[7] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Segundo mes/tercer trimestre)");
                    meses[8] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Tercer mes/tercer trimestre)");
                    meses[9] = Convert.ToInt32(Console.ReadLine());

                    //Proceso: Sacando el promedio no.3
                    promedios[3] = meses[7] + meses[8] + meses[9];
                    resultados[3] = promedios[3] / 3;
                    Console.WriteLine("Promedio: {0}", resultados[3]);
                    Console.WriteLine("Escriba [7] para volver al menu");
                    seleccion = Convert.ToInt32(Console.ReadLine());


                }

                if (seleccion == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Escriba el total de ventas (Primer mes/tercer trimestre)");
                    meses[10] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Segundo mes/tercer trimestre)");
                    meses[11] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el total de ventas (Tercer mes/tercer trimestre)");
                    meses[12] = Convert.ToInt32(Console.ReadLine());

                    //Proceso: Sacando el promedio no.3
                    promedios[4] = meses[10] + meses[11] + meses[12];
                    resultados[4] = promedios[4] / 3;
                    Console.WriteLine("Promedio: {0}", resultados[4]);
                    Console.WriteLine("Escriba [7] para volver al menu");
                    seleccion = Convert.ToInt32(Console.ReadLine());



                }

                if (seleccion == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Total de ventas correspondiente a cada trimestredel año pasado");
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("[Primer Trimestre]: {0}", resultados[1]);
                    Console.WriteLine("[Segundo Trimestre]: {0}", resultados[2]);
                    Console.WriteLine("[Tercer Trimestre]: {0}", resultados[3]);
                    Console.WriteLine("[Cuarto Trimestre]: {0}\n", resultados[4]);
                    Console.WriteLine("*En el caso de que el dato aparezca como 0, significa que aún no se han ingresado datos");
                    Console.WriteLine("Escriba [7] para volver al menu");
                    seleccion = Convert.ToInt32(Console.ReadLine());

                }

                if (seleccion == 6)
                {
                    Environment.Exit(-1);
                }


            } while (seleccion > 6);
        }
    }
}
