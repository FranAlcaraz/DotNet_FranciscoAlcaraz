using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP2.Ejercicio1
{
    class Triangulo : Calcular
    {
        private String bases;
        private String altura;
        String tipoTriangulo;
        String lado1;
        String lado2;
        String lado3;
        double resultado;
        double resultado2;

        public Triangulo(String lado1, String lado2, String lado3, String bases, String altura)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
            this.bases = bases;
            this.altura = altura;
        }

        public double CalcularArea()
        {
            resultado = (int.Parse(bases) * int.Parse(altura)) / 2;

            Console.WriteLine("El Area del Triangulo es:");

            return resultado;
        }

        public double CalcularPerimetro()
        {
            resultado = int.Parse(lado1) + int.Parse(lado2) + int.Parse(lado3);

            Console.WriteLine("El Perimetro del triangulo es: ");

            return resultado;
        }

    }
}
