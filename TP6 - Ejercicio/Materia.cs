using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6___Ejercicio
{
    class Materia
    {
        string nombre;

        public string Nombre { get {return nombre; } set { nombre = value; } }

        public override string ToString()
        {
            return nombre;
        }

    }

    
}
