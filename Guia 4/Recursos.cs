using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    public class Recursos
    {


       public int opcion;


        public void menu()
        {
            Console.WriteLine("************************************************************************");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("**                               Guia N4                              **");
            Console.WriteLine("**                                                                    **");
            Console.WriteLine("**                             Menu de Guia                           **");
            Console.WriteLine("**                                                                    **");
            Console.WriteLine("**               1). Ejemplo1                                         **");
            Console.WriteLine("**               2). Ejemplo2                                         **");
            Console.WriteLine("**               3). Ejemplo3                                         **");
            Console.WriteLine("**               4). Ejemplo4                                         **");
            Console.WriteLine("**               5). Ejemplo5                                         **");
            Console.WriteLine("**               6). Analisis de Resultados 1                         **");
            Console.WriteLine("**               7). Investigacion Complementaria 1                   **");
            Console.WriteLine("**               8). Investigacion Complementaria 2                   **");
            Console.WriteLine("**               9). Investigacion Complementaria 3                   **");
            Console.WriteLine("**               10). Investigacion Complementaria 4                  **");
            Console.WriteLine("**               11). Investigacion Complementaria 5                  **");
            Console.WriteLine("**               12). Investigacion Complementaria 6                  **");
            Console.WriteLine("**               13). Investigacion Complementaria 7                  **");
            Console.WriteLine("**               14). Investigacion Complementaria 8                  **");
            Console.WriteLine("**          :V **15). Investigacion Complementaria 9** :V             **");
            Console.WriteLine("**                                                                    **");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("************************************************************************");


        }

        public void valMenu()
        {

            string  op;


            Boolean opval = false;
            

            do
            {
                Console.Write("Ingrese el numero de la opcion que desee ejecutar:..... ");
                op = Console.ReadLine();

               //Opucpe Tryparse ya que devuelve datos booleanos
                opval = int.TryParse(op, out opcion);
                if (opval == false)
                {
                    Console.WriteLine("INGRESE UN DATO VALIDO (un numero entre el 1 al 15)");
                }
            }
 
            while(!opval);
            Console.Clear();
        }


        public void selecMenu()
        {
            // Lo hise de las 2 maneras a mi parecer me gusta mas el 'if' pero en este caso veo que es mas versatil e inclusive mas fasil el 'switch' y lei que en C# valida 3 tipos de datos char, int y string.

            switch (opcion)
            {
                case 1: Ejemplo1 eje1 = new Ejemplo1(); break;
                case 2: Ejemplo2 eje2 = new Ejemplo2(); break;
                case 3: Ejemplo3 eje3 = new Ejemplo3(); break;
                case 4: Ejemplo4 eje4 = new Ejemplo4(); break;
                case 5: Ejemplo5 eje5 = new Ejemplo5(); break;
                case 6: Anali1 ana1 = new Anali1(); break;
                case 7: Investi1 inves1 = new Investi1(); break;
                case 8: Investi2 inves2 = new Investi2(); break;
                case 9: Investi3 inves3 = new Investi3(); break;
                case 10: Investi4 inves4 = new Investi4(); break;
                case 11: Investi5 inves5 = new Investi5(); break;
                case 12: Investi6 inves6 = new Investi6(); break;
                case 13: Investi7 inves7 = new Investi7(); break;
                case 14: Investi8 inves8 = new Investi8(); break;
                case 15: investi9 inves9 = new investi9(); break;
                default:
                    menu();
                    Console.WriteLine("INGRESE UN NUMERO VALIDO (entre el 1 al 15)....");
                    valMenu();
                    selecMenu();
                    break;

            }

           /* if (opcion >= 1 && opcion <= 15)
            {
                if (opcion == 1)
                {
                    Ejemplo1 eje1 = new Ejemplo1();
                }
                else if (opcion == 2)
                {
                    Ejemplo2 eje2 = new Ejemplo2();
                }
                else if (opcion == 3)
                {
                    Ejemplo3 eje3 = new Ejemplo3();
                }
                else if (opcion == 4)
                {
                    Ejemplo4 eje4 = new Ejemplo4();
                }
                else if (opcion == 5)
                {
                    Ejemplo5 eje5 = new Ejemplo5();
                }
                else if (opcion == 6)
                {
                    Anali1 ana1 = new Anali1();
                }
                else if (opcion == 7)
                {
                    Investi1 inves1 = new Investi1();
                }
                else if (opcion == 8)
                {
                    Investi2 inves2 = new Investi2();
                }
                else if (opcion == 9)
                {
                    Investi3 inves3 = new Investi3();
                }
                else if (opcion == 10)
                {
                    Investi4 inves4 = new Investi4();
                }
                else if (opcion == 11)
                {
                    Investi5 inves5 = new Investi5();
                }
                else if (opcion == 12)
                {
                    Investi6 inves6 = new Investi6();
                }
                else if (opcion == 13)
                {
                    Investi7 inves7 = new Investi7();
                }
                else if (opcion == 14)
                {
                    Investi8 inves8 = new Investi8();
                }
                else if (opcion == 15)
                {
                    investi9 inves9 = new investi9();
                }
            }
            else
            {
                menu();
                Console.WriteLine("INGRESE UN NUMERO VALIDO (entre el 1 al 15)....");
                valMenu();
                selecMenu();
            }
*/


        }
    }
}
