using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP1.Ejercicio5
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {

            int numero = 0;
            int suma = 0;
            int contador = 0;
            float prom = 0;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            while (numero != 0)
            {

                contador++;
                suma = suma + numero;

                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
            }

            prom = suma / contador;
            Console.WriteLine("El promedio es: " + prom);
            Console.ReadKey();
        }

    }
}
