using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {

            String nombre;
            String apellido;
            String retorno;

            Console.WriteLine("Ingrese su Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido");
            apellido = Console.ReadLine();

            Console.WriteLine("Su nombre completo es:");
            retorno = nombre + " " + apellido;

            Console.WriteLine(retorno);

            Console.ReadKey();

        }
    }
}
