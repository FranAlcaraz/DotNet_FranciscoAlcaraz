using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP1.Ejercicio3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;
            int i;


            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            for (i = 0; i < numero; i++)
            {

                suma = suma + i;
            }

            Console.WriteLine("La suma total es: " + suma);
            Console.ReadKey();

        }
    }
}
