using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Ejemplo2
    {
        public Ejemplo2()
        {
            Console.WriteLine("Programa de suma, resta, divicion y multiplicacon dependiendo si el primer numero es mayor");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Double a, b, c, d; 

            Console.WriteLine("Ingrese el primer numero");
            a = Double.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese el segundo numero");
            b = Double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Mostrando resultados");
                Console.WriteLine("\n");
                c = a + b;
                Console.WriteLine("La suma es de: {0}",c);
                Console.WriteLine("\n");
                d = a - b;
                Console.WriteLine("La resta es de: {0}",d);
                Console.WriteLine("\n");
            }
            else
            {
                c = a * b;
                if (a == 0)
                {
                    Console.WriteLine("No se puede dividir el primer numero con el segundo ya que es 0");
                }
                else
                {
                    d = a / b;
                    Console.WriteLine("Mostrando resultados");
                    Console.WriteLine("\n");
                    Console.WriteLine("La multiplicacion es de {0}",c);
                    Console.WriteLine("\n");
                    Console.WriteLine("La divicion es de {0}",d);
                }
                
            }
            
            Console.WriteLine("\n");
            Console.WriteLine("Apreta cualquier tecla para cerrar");
            Console.ReadKey();


        }
    }
}
