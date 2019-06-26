using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3___Ejercicio
{
    class Test
    {
        static void Main(string[] args)
        {

            List<Materia> MisMaterias = new List<Materia>();
            int i=0;
            do
            {
                Materia aux = new Materia();
                aux.Notas = new List<Nota>();
            

                Console.Write("Ingrese una Materia: ");
                aux.Nombre = Console.ReadLine();
                Console.Write("Ingrese año de cursada (1 al 3): ");
                aux.Anio = int.Parse(Console.ReadLine());
                Console.Write("Ingrese cuatrimestre de cursada (1 al 6): ");
                aux.Cuatrimestre = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("ingrese tipo de nota (Parcial/TP) - Fecha (yyyy) - Valor de Nota: ");
                aux.Notas.Add(new Nota { Tipo = Console.ReadLine(), Fecha = int.Parse(Console.ReadLine()), Valor = int.Parse(Console.ReadLine()) });
                i++;
            } while (i < 3);

             MisMaterias.Add(aux);

            } while (MisMaterias.Count() <= 3);
            Console.ReadKey();
            
            int contador = 0;

            MisMaterias.OrderBy(x => x.Nombre).ToList();

            foreach (Materia m in MisMaterias)
            {
                if(m.Cuatrimestre == 1)
                { 
                    contador++;
                }

                Console.WriteLine("Materia: " +  m.Nombre.ToString() + "\nAño: " + m.Anio.ToString() + "\nCuatrimestre "  + m.Cuatrimestre.ToString());
                var prom = m.Notas.Average(item => item.Valor);

                
                Console.WriteLine("El promedio de la cursada de " + m.Nombre + " es: " + prom);

                
                foreach (var n in m.Notas)
                {
                    if(n.Tipo == "TP" || n.Tipo =="tp")
                    {
                        Console.WriteLine("TP: " + n.Tipo.ToString() + "\nFecha: " + n.Fecha.ToString() + "\nNota: " + n.Valor.ToString());
                    }                   
                }
            }

            Console.WriteLine("hay " + contador + " materias del primer cuatrimestre");
            Console.ReadLine();
    }
    }
}
             

