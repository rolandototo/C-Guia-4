using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Ejemplo4
    {
        public  Ejemplo4()
        {
            Console.WriteLine("Programa para identificar sexo de persona");
            int edad;
            string sexo;
            string nombre;

            Console.WriteLine("Ingrese su nombre...");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad...");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su sexo entre\n M = Hombre\n F = Mujer");
            sexo = Console.ReadLine();

            
            if (sexo == "m" || sexo == "f")
                {
                    sexo = sexo.ToUpper();
                }

            if (sexo == "M")
            {
                Console.WriteLine("\n El Sr. {0} ha sido registrado",nombre);
            }
            else if (sexo == "F")
            {
                Console.WriteLine("\n La Sra. {0} ha sido registrado", nombre);
            }


            Console.WriteLine("Aprete cualquier tecla para finalisar...");
            Console.ReadKey();
        }
    }
}
