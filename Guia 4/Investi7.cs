using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Investi7
    {
        public Investi7()
        {
            int opcion;

            menu1();
            valMenu();
            selecMenu();
            
//----------------------------------------------------------------------------------------------------------------------------------------//

            void menu1()
            {

                Console.WriteLine("************************************************************************");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("**                           Investigacion 7                          **");
                Console.WriteLine("**                                                                    **");
                Console.WriteLine("**                          Menu del programa                         **");
                Console.WriteLine("**                                                                    **");
                Console.WriteLine("**               1). Convecion de colones a dolares                   **");
                Console.WriteLine("**               2). convescion de millas a kilometros                **");
                Console.WriteLine("**               3). Convercion de calcius a fahrenheit               **");
                Console.WriteLine("**               4). Segundo Menu ---->                               **");
                Console.WriteLine("**               5). Fin programa                                     **");
                Console.WriteLine("**                                                                    **");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("************************************************************************");
            }


            void menu2()
            {

                Console.WriteLine("************************************************************************");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("**                          Investigacion 7                           **");
                Console.WriteLine("**                                                                    **");
                Console.WriteLine("**                       SubMenu del programa                         **");
                Console.WriteLine("**                                                                    **");
                Console.WriteLine("**               1). Si es positivo o negativo                        **");
                Console.WriteLine("**               2). Area de un triangulo                             **");
                Console.WriteLine("**               3). <---- Primer menu                                **");
                Console.WriteLine("**                                                                    **");
                Console.WriteLine("**                          Fin submenu                               **");
                Console.WriteLine("**                                                                    **");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("************************************************************************");
            }

//----------------------------------------------------------------------------------------------------------------------------------------//

            void valMenu()
            {

                string op;


                Boolean opval = false;


                do
                {
                    Console.Write("Ingrese el numero de la opcion que desee ejecutar:..... ");
                    op = Console.ReadLine();

                    opval = int.TryParse(op, out opcion);
                    if (opval == false)
                    {
                        Console.WriteLine("INGRESE UN DATO VALIDO (un numero entre el 1 al 5)");
                    }
                }

                while (!opval);
                Console.Clear();
            }

            void valmenu2()
            {

                string op;


                Boolean opval = false;


                do
                {
                    Console.Write("Ingrese el numero de la opcion que desee ejecutar:..... ");
                    op = Console.ReadLine();

                    opval = int.TryParse(op, out opcion);
                    if (opval == false)
                    {
                        Console.WriteLine("INGRESE UN DATO VALIDO (un numero entre el 1 al 3)");
                    }
                }

                while (!opval);
                Console.Clear();
            }


//----------------------------------------------------------------------------------------------------------------------------------------//

            void selecMenu()
            {
                switch (opcion)
                {
                    case 1: conColDol(); break;
                    case 2: conMiKm(); break;
                    case 3: conCelFah(); break;
                    case 4: iniMenu2(); break;
                    case 5: Fin(); break;

                    default:
                        menu1();
                        Console.WriteLine("INGRESE UN NUMERO VALIDO (entre el 1 al 5)....");
                        valMenu();
                        selecMenu();
                        break;

                }
                

            }

            void selecMenu2()
            {
                switch (opcion)
                {
                    case 1: siPosNeg(); break;
                    case 2: areTrian(); break;
                    case 3: regresar(); break;

                    default:
                        menu2();
                        Console.WriteLine("INGRESE UN NUMERO VALIDO (entre el 1 al 3)....");
                        valmenu2();
                        selecMenu2();
                        break;

                }
            }



//----------------------------------------------------------------------------------------------------------------------------------------//

            void conColDol()
            {
                Console.WriteLine("A elegindo la opcion de Convescion de Colones Salvadore;os a Dolares");
                double col, dol;
                Console.WriteLine("\nIngrese la cantidad de Colones a convertir");
                col = double.Parse(Console.ReadLine());
                dol = col * 0.11;
                Console.WriteLine("{0} Colones Salvadore;os es igual a {1} Dolares",col,dol);
                

            }
            void conMiKm()
            {
                Console.WriteLine("A elegindo la opcion de Convescion de Millas a Kilometros");
                double mi, km;
                Console.WriteLine("\nIngrese la cantidad de Millas a convertir");
                mi = double.Parse(Console.ReadLine());
                km  = mi * 1.60934;
                Console.WriteLine("{0} Millas es igual a {1} Kilometros", mi, km);
            }
            void conCelFah()
            {
                Console.WriteLine("A elegindo la opcion de Convescion de Celcius a Fahrenheit");
                double cel, fa;
                Console.WriteLine("\nIngrese la cantidad de Celcius a Fahrenheir");
                cel = double.Parse(Console.ReadLine());
                fa = (1.8 * cel) + 32;
                Console.WriteLine("{0} Celcius es igual a {1} Fahrenheir", cel, fa);
            }
            void iniMenu2()
            {
                Console.Clear();
                menu2();
                valmenu2();
                selecMenu2();               
            }
            void Fin()
            {
                Console.WriteLine("A elegindo la opcion de finalizar progrma apreta una tecla para salir");
                Console.ReadKey();
                Environment.Exit(0);
            }
            //----------------------------------------------------------------------------------------------------------------------------------------//

            void siPosNeg()
            {
                Console.WriteLine("A elegindo la opcion de identificador de positivos y negativos");
                double num;
                Console.WriteLine("\nIngrese el numero a identificar");
                num = double.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("El numero {0} es Negativo",num);
                }
                else
                {
                    Console.WriteLine("El numero {0} es Positivo",num);
                }
            }
            void areTrian()
            {
                Console.WriteLine("A elegindo la opcion de Resolucion de area de triangulo");
                double bas, alt, area;
                Console.WriteLine("\nIngrese la cantidad de la base");
                bas = double.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese la cantidad de la altura");
                alt = double.Parse(Console.ReadLine());
                area = (bas * alt) / 2;
                Console.WriteLine("\nEl area del triangulo proporcionado es de: "+area);
            }

            void regresar()
            {
                Console.Clear();
                menu1();
                valMenu();
                selecMenu();
            }



            Console.ReadKey();
        }
    }
}
