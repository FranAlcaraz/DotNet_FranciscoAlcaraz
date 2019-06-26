using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP1.Ejercicio4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un valor");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese ingrese otro valor");
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado");

            int i;

            for (i = v1; i > 0; i--)
            {
                if (v1 % i == 0 && v2 % i == 0)
                {
                    Console.WriteLine("El mcd entre {0} y {1} es {2}", v1, v2, i);
                    break;
                }
            }
            Console.ReadKey();
        }


    }
}
