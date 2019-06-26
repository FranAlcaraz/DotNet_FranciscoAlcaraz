using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP1.Ejercicio2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            String nombre;
            int edad;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("Ud. es Menor, no puede ingresar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ud. es Mayor, puede ingresar");
                Console.ReadKey();
            }


        }
    }
}
