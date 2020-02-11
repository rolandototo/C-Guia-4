using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Investi5
    {
        public Investi5()
        {
            //Dise;ar un progrma que nos permita saber si son pares o impares los numero

            Console.WriteLine("Dise;ar un progrma que nos permita saber si son pares o impares los numero");
            Console.WriteLine("\n");



            double a, b, par1, par2, impar1, impar2;

            Console.WriteLine("Escribe el primer numero");
            a = double.Parse(Console.ReadLine());


            Console.WriteLine("Escribe el segundo numero");
            b = double.Parse(Console.ReadLine());

            par1 = a % 2;
            par2 = b % 2;

            impar1 = a % 3;
            impar2 = b % 3;


            if (par1 == 0 && par2 == 0)
            {
                Console.WriteLine("Los 2 numero son pares");
            }
            else if (impar1 == 0 && impar2 == 0)
            {
                Console.WriteLine("Los 2 numero son impares");
            }
            else if (par1 == 0)
            {
                Console.WriteLine("El numero {0} es par", a);
                if (impar2 == 0)
                {
                    Console.WriteLine("El numero {0} es impar", b)
                }

            }
            else if (impar1 == 0) 
            {
                Console.WriteLine("El numero {0} es impar", a);
                if (par2 == 0)
                {
                    Console.WriteLine("El numero {0} es par", b);
                }

            }
            Console.ReadKey();

        }

    }
}
