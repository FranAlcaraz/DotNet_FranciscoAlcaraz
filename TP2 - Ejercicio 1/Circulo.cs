using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP2.Ejercicio1
{
    class Circulo : Calcular
    {
        String radio;
        double pi = 3.14;
        double resultado;
        double resultado2;

        public Circulo(String radio)
        {
            this.radio = radio;
        }

        public double CalcularArea()
        {
            resultado = pi * Math.Pow(int.Parse(radio), 2);

            Console.WriteLine("El Area del circulo es: ");

            return resultado;
        }

        public double CalcularPerimetro()
        {
            resultado2 = (2 * int.Parse(radio)) * pi;

            Console.WriteLine("El Perimetro del circulo es: ");

            return resultado2;
        }

    }
}
