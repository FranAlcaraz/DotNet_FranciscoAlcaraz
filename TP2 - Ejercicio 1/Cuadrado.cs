using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP2.Ejercicio1
{
    class Cuadrado : Calcular
    {
        String lado;
        double resultado;
        double resultado2;

        public Cuadrado(String lado)
        {
            this.lado = lado;
        }
        public double CalcularArea()
        {
            resultado = Math.Pow(int.Parse(lado), 2);

            Console.WriteLine("El Area del Cuadrado es:");

            return resultado;
        }

        public double CalcularPerimetro()
        {
            resultado2 = 4 * int.Parse(lado);
            Console.WriteLine("El Perimetro del Cuadrado es:");

            return resultado2;
        }

    }
}
