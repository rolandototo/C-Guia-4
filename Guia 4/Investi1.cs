using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Investi1
    {
        public Investi1()
        {
            //Dise;ar un progrma que nos permita saber cual es el mayor entre 2 numeros

            Console.WriteLine("Dise;ar un progrma que nos permita saber cual es el mayor entre 2 numeros");
            Console.WriteLine("\n");

            Console.WriteLine("El mayor entre 2 numeros");
            Console.WriteLine("\n");

            int a, b;

            Console.WriteLine("Escribe el primer numero");
            a = int.Parse(Console.ReadLine());


            Console.WriteLine("Escribe el segundo numero");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("El numero {0} es mayor que {1}", a, b);
            }
            else if (a == b)
            {
                Console.WriteLine("El numero {0} es igual que {1}", a, b);
            }
            else
            {
                Console.WriteLine("El numero {1} es mayor que {0}", a, b);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Apreta cualquier tecla para cerrar");
            Console.ReadKey();
        }
    }
}
