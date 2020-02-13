using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class investi9
    {
        public investi9()
        {
            int diaM, mes, dia;

            iniD();
            Console.WriteLine("El {0}, del mes {1}, es el dia {2} del Año", diaM, mes, dia);
            Console.ReadKey();

//-------------------------------------------------------------------------------------------------------------------------------------//

            void iniD()
            {
                Console.Clear();
                Console.WriteLine("Calculo del Dia del Año");
                Console.WriteLine("\nIngrese el dia del mes. Por ejemplo dia '4' del mes");
                
                valMenuDia();
                filtroDia();
            }
            void iniM()
            {
                Console.WriteLine("\nIngrese el numero del mes del dia que quiere saber");
                
                valMenuMes();
                ope();
            }

//-------------------------------------------------------------------------------------------------------------------------------------//

            void valMenuDia()
            {

                string op;


                Boolean opval = false;


                do
                {
                    Console.Write("Ingrese el numero del dia:..... ");
                    op = Console.ReadLine();

                    opval = int.TryParse(op, out diaM);
                    if (opval == false)
                    {
                        Console.WriteLine("INGRESE UN DATO VALIDO (un numero entre el 1 al 31)");
                    }
                }

                while (!opval);
                Console.Clear();
            }

            void valMenuMes()
            {

                string op;


                Boolean opval = false;


                do
                {
                    Console.Write("Ingrese el numero del mes:..... ");
                    op = Console.ReadLine();

                    opval = int.TryParse(op, out mes);
                    if (opval == false)
                    {
                        Console.WriteLine("INGRESE UN DATO VALIDO (un numero entre el 1 al 12)");
                    }
                }

                while (!opval);
                Console.Clear();
            }


//-------------------------------------------------------------------------------------------------------------------------------------//


            void filtroDia()
            {
                if (diaM >= 1 && diaM <=31)
                {
                    iniM();
                }
                else
                {
                    Console.WriteLine("Ingrese un numero valido entre el 1 al 31");
                    Console.WriteLine("Presiones cualquier tecla para reiniciar......");
                    Console.ReadKey();
                    iniD();
                }
            }


//-------------------------------------------------------------------------------------------------------------------------------------//

            void ope()
            {
                switch(mes)
                {
                    case 1: dia = diaM; break;
                    case 2: dia = diaM + 31; break;
                    case 3: dia = diaM + 59; break;
                    case 4: dia = diaM + 90; break;
                    case 5: dia = diaM + 120; break;
                    case 6: dia = diaM + 151; break;
                    case 7: dia = diaM + 181; break;
                    case 8: dia = diaM + 212; break;
                    case 9: dia = diaM + 243; break;
                    case 10: dia = diaM + 273; break;
                    case 11: dia = diaM + 304; break;
                    case 12: dia = diaM + 334; break;

                    default:
            
                    Console.WriteLine("INGRESE UN NUMERO VALIDO (entre el 1 al 12)....");
                    Console.WriteLine("Presiones cualquier tecla para reiniciar......");
                    Console.ReadKey();
                    Console.Clear();
                    iniM();
                    break;

                }
            }

        }
    }
}
