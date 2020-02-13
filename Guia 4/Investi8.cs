using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Investi8
    {
        public Investi8()
        {
            int opcion;
            double kg;
            Console.WriteLine("Programa para Hacer convercion de de kg a lo que uno desee segun el menu ");
            Console.WriteLine("\nIngrese la cantidad en kigramos que desea convertir");
            kg = double.Parse(Console.ReadLine());
            menu1();
            valMenu();
            selecMenu();
            Console.ReadKey();


            void menu1()
            {


                Console.WriteLine("************************************************************************");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("**                           Investigacion 8                          **");
                Console.WriteLine("**                                                                    **");
                Console.WriteLine("**                          Menu del programa                         **");
                Console.WriteLine("**                                                                    **");
                Console.WriteLine("**               1). Convecion a libras                               **");
                Console.WriteLine("**               2). convescion a onzas                               **");
                Console.WriteLine("**               3). Convercion a toneladas                           **");
                Console.WriteLine("**                                                                    **");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("************************************************************************");
            }



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
                        Console.WriteLine("INGRESE UN DATO VALIDO (un numero entre el 1 al 3)");
                    }
                }

                while (!opval);
                Console.Clear();
            }



            void selecMenu()
            {
                switch (opcion)
                {
                    case 1: libras(); break;
                    case 2: onzas(); break;
                    case 3: ton(); break;

                    default:
                        menu1();
                        Console.WriteLine("INGRESE UN NUMERO VALIDO (entre el 1 al 3)....");
                        valMenu();
                        selecMenu();
                        break;

                }
            }

            void libras()
            {
                double lib;

                Console.WriteLine("Convercion a libras");
                lib = kg * 2.20462;
                Console.WriteLine("\n{0}Kg es igual a {1}Libras", kg,lib);

            }
            void onzas()
            {
                double onz;
                Console.WriteLine("Convercion a Onzas");
                onz = kg * 35.274;
                Console.WriteLine("\n{0}Kg es igual a {1}Onzas", kg, onz);
            }
            void ton()
            {
                double tone;
                Console.WriteLine("Convercion a Toneladas");
                tone = kg * 0.00100000108;
                Console.WriteLine("\n{0}Kg es igual a {1}Toneladas", kg, tone);
            }

        }
    }
}
