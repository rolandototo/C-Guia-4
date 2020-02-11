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
            //Dise;ar un progrma que nos permita saber cual es el mayor entre 3 numeros

            Console.WriteLine("Dise;ar un progrma que nos permita saber cual es el mayor entre 3 numeros");
            Console.WriteLine("\n");

            Console.WriteLine("El mayor entre 3 numeros");
            Console.WriteLine("\n");

            double a, b, c;

            Console.WriteLine("Escribe el primer numero");
            a = double.Parse(Console.ReadLine());


            Console.WriteLine("Escribe el segundo numero");
            b = double.Parse(Console.ReadLine());
            

            Console.WriteLine("Escribe el tercer numero");
            c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("El numero {0} es el mayor",a);
                if (b > c)
                {
                    Console.WriteLine("El numero {0} es el de enmedio", b);
                    Console.WriteLine("El numero {0} es el menor", c);
                }
                else 
                {
                    Console.WriteLine("El numero {0} es el de enmedio", c);
                    Console.WriteLine("El numero {0} es el menor", b);
                }
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("El numero {0} es el mayor",b);
                if (a > c)
                {
                    Console.WriteLine("El numero {0} es el de enmedio", a);
                    Console.WriteLine("El numero {0} es el menor", c);
                }
                else 
                {
                    Console.WriteLine("El numero {0} es el de enmedio", c);
                    Console.WriteLine("El numero {0} es el menor", a);
                }
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("El numero {0} es el mayor",c);
                if (b > a)
                {
                  Console.WriteLine("El numero {0} es el de enmedio", b);
                  Console.WriteLine("El numero {0} es el menor", a);
                }
                else 
                {
                    Console.WriteLine("El numero {0} es el de enmedio", a);
                    Console.WriteLine("El numero {0} es el menor", b);
                }
            }
            
            Console.WriteLine("\n");
            Console.WriteLine("Apreta cualquier tecla para cerrar");
            Console.ReadKey();
        }
    }
}
