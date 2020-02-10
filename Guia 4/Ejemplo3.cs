using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Ejemplo3
    {
        public Ejemplo3()
        {
            Double a, b, c, x1, x2, raiscont;


            inicio();
            profiltro();
            void inicio() 
                { 
                Console.WriteLine("Programa para encontrar las raices de una ecuacion cuadratica");
                Console.WriteLine("\n");
                Console.WriteLine("Las raices reales de la exprecion            ax^2 + bx + c = 0");
                Console.WriteLine("\n");
                Console.WriteLine("La ecuacion cuadratica es:");
                Console.WriteLine("\n");
                Console.WriteLine("                               ___________");
                Console.WriteLine("                         -b ± / b^2 - 4ac");
                Console.WriteLine("                    x = ------------------");
                Console.WriteLine("                               2a");
                Console.WriteLine("\n");
                Console.WriteLine("Siendo X1 en positivo\nSiendo X2 en negativo\n");


                

                Console.WriteLine("Ingrese el valor de 'a' de la formula...");
                a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de 'b' de la formula...");
                b = Double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de 'c' de la formula...");
                c = Double.Parse(Console.ReadLine());

                raiscont = (Math.Pow(b, 2)) - (4 * (a * c));
                }

            void profiltro()
            {
                if(a==0)
                {
                    Console.WriteLine("El valos de 'a' tiene que ser diferente a 0\nIngrese datos validos...");
                    Console.WriteLine("Precione cualquier tecla para reiniciar el programa...");
                    Console.ReadKey();
                    Console.Clear();
                    inicio();
                    profiltro();
                }
                else
                {
                    if (raiscont < 0)
                    {
                        Console.WriteLine("Error\nLa rais cuadrada no tiene que tener un contenido negativo\nIngresar valores validos...");
                        Console.WriteLine("Precione cualquier tecla para reiniciar el programa...");
                        Console.ReadKey();
                        Console.Clear();
                        inicio();
                        profiltro();
                    }
                    else
                    {
                        
                        

                        x1 = ((-b) + (Math.Sqrt(raiscont))) / (2 * a);

                        x2 = ((-b) - (Math.Sqrt(raiscont))) / (2 * a);

                        Console.WriteLine("X1 = "+Math.Round(x1,3)+"\nX2 = "+Math.Round(x2,3));

                        Console.WriteLine("Aprete cualquier tecla para finalisar...");
                        Console.ReadKey();

                    }
                }

               
            }


        }
    }
}
