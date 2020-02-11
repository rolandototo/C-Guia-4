using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Investi4
    {

        public Investi4()
        {
            //Dise;ar un progrma que nos permita saber si el tercero es igual a ala suma de los primeros 2

            Console.WriteLine("Dise;ar un progrma que nos permita saber si el tercero es igual a la suma de los primeros 2");
            Console.WriteLine("\n");


            double a, b, c, resultado;

            Console.WriteLine("Escribe el primer numero");
            a = double.Parse(Console.ReadLine());


            Console.WriteLine("Escribe el segundo numero");
            b = double.Parse(Console.ReadLine());


            Console.WriteLine("Escribe el tercer numero");
            c = double.Parse(Console.ReadLine());

            resultado = a + b;

            if (c == resultado)
            {
                Console.WriteLine("El numero {0} es igual a la suma de {1} + {2}", c, a, b);
            }
            else {
                Console.WriteLine("El numero {0} no es igual a la suma de {1} + {2}", c, a, b);
            }

            Console.ReadKey();


        }
        

    }
}
