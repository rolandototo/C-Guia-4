using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Investi3
    {
        public Investi3()
        {
            //Dise;ar un progrma que nos permita saber si el primer numero es multiplo del segundo

            Console.WriteLine("Dise;ar un progrma que nos permita saber si el primer numero es multiplo del segundo");
            Console.WriteLine("\n");


            double a, b, c;

            Console.WriteLine("Escribe el primer numero");
            a = double.Parse(Console.ReadLine());


            Console.WriteLine("Escribe el segundo numero");
            b = double.Parse(Console.ReadLine());


            c = a % b;

            if (c == 0 )
            {
                Console.WriteLine("El numero {0} es multiplo de {1}", a, b);
            }
            else
            {
                Console.WriteLine("Los numeros no son multiplos entre si.");
            }
            Console.ReadKey();
        }

        
    }
}
