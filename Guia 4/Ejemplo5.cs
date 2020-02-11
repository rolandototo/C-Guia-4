using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Ejemplo5
    {
        public  Ejemplo5()
        {
            int opcion;
            double resultado, resultado2, num1, num2;
           

            void inicio()
            {
                Console.WriteLine("Ingrese el primer numero");
                num1 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero");
                num2 = Double.Parse(Console.ReadLine());
            }


            inicio();
            menu();
            valMenu();
            selecMenu();
            

            //-----------------------------------------------------------------------------------------------------------------------------------//
            //-----------------------------------------------------------------------------------------------------------------------------------//

            void menu()
            {
                Console.WriteLine("************************************************************************");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("**                               Ejemplo 5                            **");
                Console.WriteLine("**                                                                    **");
                Console.WriteLine("**                             Menu del programa                      **");
                Console.WriteLine("**                                                                    **");
                Console.WriteLine("**               1). Suma                                             **");
                Console.WriteLine("**               2). Resta                                            **");
                Console.WriteLine("**               3). Multiplicacion                                   **");
                Console.WriteLine("**               4). Divicion                                         **");
                Console.WriteLine("**               5). Raiz cuadrada                                    **");
                Console.WriteLine("**               6). Exponenciacion                                   **");
                Console.WriteLine("**               7). Salir programa                                   **");
                Console.WriteLine("**                                                                    **");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("************************************************************************");
            }

            //-----------------------------------------------------------------------------------------------------------------------------------//

            void valMenu()
            {

                string op;


                Boolean opval = false;


                do
                {
                    Console.Write("Ingrese el numero de la opcion que desee ejecutar:..... ");
                    op = Console.ReadLine();

                    //Ocupe Tryparse ya que devuelve datos booleanos
                    opval = int.TryParse(op, out opcion);
                    if (opval == false)
                    {
                        Console.WriteLine("INGRESE UN DATO VALIDO (un numero entre el 1 al 7)");
                    }
                }

                while (!opval);
                Console.Clear();
            }

            //-----------------------------------------------------------------------------------------------------------------------------------//

            void selecMenu()
            {

                switch (opcion)
                {
                    case 1: suma(); break;
                    case 2: resta(); break;
                    case 3: multiplicacion(); break;
                    case 4: divicion(); break;
                    case 5: raiz(); break;
                    case 6: expo(); break;
                    case 7: exit(); break;

                    default:
                        menu();
                        Console.WriteLine("INGRESE UN NUMERO VALIDO (entre el 1 al 7)....");
                        valMenu();
                        selecMenu();
                        break;

                }

            }

            //-----------------------------------------------------------------------------------------------------------------------------------//
            //-----------------------------------------------------------------------------------------------------------------------------------//

            void suma()
            {
                Console.WriteLine("\n\n\nHas elegido la opcion de suma.....\nPulse una tecla para continuar.....");
                Console.ReadKey();
                resultado = num1 + num2;

                Console.WriteLine("El resultado de la Suma: "+resultado);
                Console.ReadKey();
            }

            //-----------------------------------------------------------------------------------------------------------------------------------//

            void resta()
            {
                Console.WriteLine("\n\n\nHas elegido la opcion de resta.....\nPulse una tecla para continuar.....");
                Console.ReadKey();
                resultado = num1 - num2;

                Console.WriteLine("El resultado de la resta: " + resultado);
                Console.ReadKey();
            }

            //-----------------------------------------------------------------------------------------------------------------------------------//

            void multiplicacion()
            {
                Console.WriteLine("\n\n\nHas elegido la opcion de multiplicacion.....\nPulse una tecla para continuar.....");
                Console.ReadKey();
                resultado = num1 * num2;

                Console.WriteLine("El resultado de la multiplicacion: " + resultado);
                Console.ReadKey();
            }

            //-----------------------------------------------------------------------------------------------------------------------------------//

            void divicion()
            {
                Console.WriteLine("\n\n\nHas elegido la opcion de divicion.....\nPulse una tecla para continuar.....");
                Console.ReadKey();
                resultado = num1 / num2;

                Console.WriteLine("El resultado de la divicion: " + resultado);
                Console.ReadKey();
            }

            //-----------------------------------------------------------------------------------------------------------------------------------//

            void raiz()
            {
                Console.WriteLine("\n\n\nHas elegido la opcion de raiz cuadrada.....\nPulse una tecla para continuar.....");
                Console.ReadKey();
                
                resultado = Math.Sqrt(num1);
                resultado2 = Math.Sqrt(num2);

                if (num1 < 0 || num2 < 0)
                {
                    Console.WriteLine("A elegido un dato incorecto una raiz no debe ser negativa");
                    Console.WriteLine("Aprete caulquier tecla para empezar");
                    Console.ReadKey();
                    Console.Clear();
                    inicio();
                    menu();
                    valMenu();
                    selecMenu();
                }
                else
                {
                    Console.WriteLine("El resultado de la raiz cuadrad del primer numero es: " + resultado);
                    Console.WriteLine("El resultado de la raiz cuadrad del segundo numero es: " + resultado2);
                    Console.ReadKey();
                }
                
            }

            //-----------------------------------------------------------------------------------------------------------------------------------//

            void expo()
            {
                Console.WriteLine("\n\n\nHas elegido la opcion de Exponenciasion.....\nPulse una tecla para continuar.....");
                Console.ReadKey();

                resultado = Math.Pow(num1, num2);

                Console.WriteLine("El resultado de la potencia siendo la base el primer numero y la potencia el segundo: " + resultado);
                Console.ReadKey();
            }

            //-----------------------------------------------------------------------------------------------------------------------------------//

            void exit()
            {
                Environment.Exit(0);
            }



        }
    }
}
