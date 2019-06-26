using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP2.Ejercicio1
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Radio del Circulo");
            Circulo c1 = new Circulo(Console.ReadLine());
            Console.WriteLine(c1.CalcularArea());
            Console.WriteLine(c1.CalcularPerimetro());
            Console.ReadKey();

            Console.WriteLine("Ingrese el Lado del Cuadrado");
            Cuadrado cuad1 = new Cuadrado(Console.ReadLine());
            Console.WriteLine(cuad1.CalcularArea());
            Console.WriteLine(cuad1.CalcularPerimetro());
            Console.ReadKey();

            Console.WriteLine("Ingrese los 3 lados, la base y la altura del Triangulo");
            Triangulo t1 = new Triangulo(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(t1.CalcularArea());
            Console.WriteLine(t1.CalcularPerimetro());
            Console.ReadKey();
        }



    }
}
