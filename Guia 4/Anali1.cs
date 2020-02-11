using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Anali1
    {
        public Anali1()
        {
            double preguntas, respuestas, porcentage;
            inicio();
            filtro();
            Console.ReadKey();


            void inicio()
            {
                Console.WriteLine("Programa para saber el nivel de aprobacion de respuestas.");
                Console.WriteLine("\nIngrese La  cantidad de preguntas en numeros que le realizaron.");
                preguntas = double.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese La  cantidad de preguntas que contesto correctamente.");
                respuestas = double.Parse(Console.ReadLine());

                porcentage = (respuestas / preguntas)* 100;
            }

            void filtro()
            {
                if (porcentage >= 90)
                {
                    Console.WriteLine("\nSe encuentra en el nivel maximo con {0}.", porcentage);

                }

                if (porcentage >= 75 && porcentage < 90)
                {
                    Console.WriteLine("\nSe encuentra en el nivel medio con {0}.", porcentage);

                }

                if (porcentage >= 50 && porcentage < 75)
                {
                    Console.WriteLine("\nSe encuentra en el nivel regular con {0}.", porcentage);

                }

                if (porcentage < 50)
                {
                    Console.WriteLine("\nSe encuentra Fuera de nivel con {0}.", porcentage);


                }
                else
                {
                    Console.WriteLine("\nIngrese datos validos para poder hacer la operacion.");
                    inicio();
                    filtro();
                    Console.ReadKey();
                }
            }

            



        }
    }
}
