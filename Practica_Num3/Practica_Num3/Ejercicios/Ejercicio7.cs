using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Num3.Ejercicios
{
    class Ejercicio7
    {
        static void Main(string[] args)
        {
            decimal unidadInicio;
            decimal unidadFinal;
            int menu1;
            int menu2;
            decimal unidadConvertida;

            //Arreglo:


            //Proceso: Menu
            do
            {
                Console.Clear();
                Console.WriteLine("Conversión de unidades: Masa");
                Console.WriteLine("\n--Elija la unidad de Inicio--");
                Console.WriteLine("[1] Onza");
                Console.WriteLine("[2] Libra");
                Console.WriteLine("[3] Gramo");
                Console.WriteLine("[4] Tonelada");
                Console.Write("\nSelección: ");
                menu1 = Convert.ToInt32(Console.ReadLine());

                //Convercion
                if (menu1 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ha escogido la Unidad de inicio: [1] Onza");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n--Elija a que unidad quiere convertir Onzas--");
                    do
                    {
                        //Menu 2
                        Console.WriteLine("[1] Libra");
                        Console.WriteLine("[2] Gramo");
                        Console.WriteLine("[3] Tonelada");
                        Console.WriteLine("[4] Volver al menu principal");
                        Console.Write("\nSelección: ");
                        menu2 = Convert.ToInt32(Console.ReadLine());


                        if (menu2 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("---Onzas a libras---");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Escriba el numero de Onzas: ");
                            unidadInicio = Convert.ToDecimal(Console.ReadLine());
                            unidadFinal = unidadInicio / 16;
                            unidadConvertida = Math.Truncate(unidadFinal * 100) / 100;
                            Console.WriteLine("Sus {0} Onzas equivalen a {1} Libras", unidadInicio, unidadConvertida);
                            Console.ReadKey();
                        }

                        else
                        {
                            if (menu2 == 2)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---Onzas a Gramos---");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Escriba el numero de Onzas: ");
                                unidadInicio = Convert.ToDecimal(Console.ReadLine());
                                unidadFinal = unidadInicio * 28.35m;
                                unidadConvertida = Math.Truncate(unidadFinal * 100) / 100;
                                Console.WriteLine("Sus {0} Onzas equivalen a {1} Gramos", unidadInicio, unidadConvertida);
                                Console.ReadKey();
                            }

                            else
                            {
                                if (menu2 == 3)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("---Onzas a Toneladas---");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Escriba el numero de Onzas: ");
                                    unidadInicio = Convert.ToDecimal(Console.ReadLine());
                                    unidadFinal = unidadInicio / 35273.962m;
                                    unidadConvertida = Math.Truncate(unidadFinal * 100) / 100;
                                    Console.WriteLine("Sus {0} Onzas equivalen a {1} Toneladas", unidadInicio, unidadConvertida);
                                    Console.ReadKey();
                                }

                            }
                        }
                    } while (menu2 >= 4);
                }

                if (menu1 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ha escogido la Unidad de inicio: [2] Libras");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n--Elija a que unidad quiere convertir Libras--");
                    do
                    {
                        //Menu 2
                        Console.WriteLine("[1] Onzas");
                        Console.WriteLine("[2] Gramo");
                        Console.WriteLine("[3] Tonelada");
                        Console.WriteLine("[4] Volver al menu principal");
                        Console.Write("\nSelección: ");
                        menu2 = Convert.ToInt32(Console.ReadLine());


                        if (menu2 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("---Libras a Onzas---");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Escriba el numero de Libras: ");
                            unidadInicio = Convert.ToDecimal(Console.ReadLine());
                            unidadFinal = unidadInicio * 16;
                            unidadConvertida = Math.Truncate(unidadFinal * 100) / 100;
                            Console.WriteLine("Sus {0} Libras equivalen a {1} Onzas", unidadInicio, unidadConvertida);
                            Console.ReadKey();
                        }

                        else
                        {
                            if (menu2 == 2)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---Libras a Gramos---");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Escriba el numero de Libras: ");
                                unidadInicio = Convert.ToDecimal(Console.ReadLine());
                                unidadFinal = unidadInicio * 453.592m;
                                unidadConvertida = Math.Truncate(unidadFinal * 100) / 100;
                                Console.WriteLine("Sus {0} Libras equivalen a {1} Gramos", unidadInicio, unidadConvertida);
                                Console.ReadKey();
                            }

                            else
                            {
                                if (menu2 == 3)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("---Libras a Toneladas---");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Escriba el numero de Libras: ");
                                    unidadInicio = Convert.ToDecimal(Console.ReadLine());
                                    unidadFinal = unidadInicio / 2204.62m;
                                    unidadConvertida = Math.Truncate(unidadFinal * 100) / 100;
                                    Console.WriteLine("Sus {0} Libras equivalen a {1} Toneladas", unidadInicio, unidadConvertida);
                                    Console.ReadKey();
                                }

                            }
                        }
                    } while (menu2 >= 4);
                }

                if (menu1 == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ha escogido la Unidad de inicio: [3] Gramos");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n--Elija a que unidad quiere convertir Gramos--");
                    do
                    {
                        //Menu 2
                        Console.WriteLine("[1] Onzas");
                        Console.WriteLine("[2] Libras");
                        Console.WriteLine("[3] Tonelada");
                        Console.WriteLine("[4] Volver al menu principal");
                        Console.Write("\nSelección: ");
                        menu2 = Convert.ToInt32(Console.ReadLine());


                        if (menu2 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("---Gramos a Onzas---");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Escriba el numero de Gramos: ");
                            unidadInicio = Convert.ToDecimal(Console.ReadLine());
                            unidadFinal = unidadInicio / 28.35m;
                            unidadConvertida = Math.Truncate(unidadFinal * 100) / 100;
                            Console.WriteLine("Sus {0} gramos equivalen a {1} Onzas", unidadInicio, unidadConvertida);
                            Console.ReadKey();
                        }

                        else
                        {
                            if (menu2 == 2)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---Gramos a Libras---");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Escriba el numero de Gramos: ");
                                unidadInicio = Convert.ToDecimal(Console.ReadLine());
                                unidadFinal = unidadInicio / 453.592m;
                                unidadConvertida = Math.Truncate(unidadFinal * 100) / 100;
                                Console.WriteLine("Sus {0} Gramos equivalen a {1} Libras", unidadInicio, unidadConvertida);
                                Console.ReadKey();
                            }

                            else
                            {
                                if (menu2 == 3)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("---Gramos a Toneladas---");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Escriba el numero de Gramoss: ");
                                    unidadInicio = Convert.ToDecimal(Console.ReadLine());
                                    unidadFinal = unidadInicio / 1000000m;
                                    unidadConvertida = Math.Truncate(unidadFinal * 100) / 100;
                                    Console.WriteLine("Sus {0} Gramos equivalen a {1} Toneladas", unidadInicio, unidadConvertida);
                                    Console.ReadKey();
                                }

                            }
                        }
                    } while (menu2 >= 4);
                }

                if (menu1 == 4)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ha escogido la Unidad de inicio: [4] Toneladas");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n--Elija a que unidad quiere convertir Toneladas--");
                    do
                    {
                        //Menu 2
                        Console.WriteLine("[1] Onzas");
                        Console.WriteLine("[2] Libras");
                        Console.WriteLine("[3] Gramos");
                        Console.WriteLine("[4] Volver al menu principal");
                        Console.Write("\nSelección: ");
                        menu2 = Convert.ToInt32(Console.ReadLine());


                        if (menu2 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("---Toneladas a Onzas---");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Escriba el numero de Toneldas: ");
                            unidadInicio = Convert.ToDecimal(Console.ReadLine());
                            unidadFinal = unidadInicio * 35273.962m;
                            unidadConvertida = Math.Truncate(unidadFinal * 100) / 100;
                            Console.WriteLine("Sus {0} Toneladas equivalen a {1} Onzas", unidadInicio, unidadConvertida);
                            Console.ReadKey();
                        }

                        else
                        {
                            if (menu2 == 2)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---Toneladas a Libras---");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Escriba el numero de Toneladas: ");
                                unidadInicio = Convert.ToDecimal(Console.ReadLine());
                                unidadFinal = unidadInicio * 2204.623m;
                                unidadConvertida = Math.Truncate(unidadFinal * 100) / 100;
                                Console.WriteLine("Sus {0} Toneladas equivalen a {1} Libras", unidadInicio, unidadConvertida);
                                Console.ReadKey();
                            }

                            else
                            {
                                if (menu2 == 3)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("---Toneladas a Gramos---");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Escriba el numero de Toneladas: ");
                                    unidadInicio = Convert.ToDecimal(Console.ReadLine());
                                    unidadFinal = unidadInicio * 1000000m;
                                    unidadConvertida = Math.Truncate(unidadFinal * 100) / 100;
                                    Console.WriteLine("Sus {0} Toneladas equivalen a {1} Gramos", unidadInicio, unidadConvertida);
                                    Console.ReadKey();
                                }

                            }
                        }
                    } while (menu2 >= 4);
                }


            } while (menu1 >= 5);
        }
    }
}
