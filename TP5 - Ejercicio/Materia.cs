using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3___Ejercicio
{
    class Materia
    {
        private string nombre;
        private int anio;
        private int cuatrimestre;
        public List<Nota> Notas;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        public int Cuatrimestre
        {
            get { return cuatrimestre; }
            set { cuatrimestre = value; }
        }

        public override string ToString()
        {
            return "Materia: " + nombre + "\nAño: " + anio + "\nCuatrimestre: " + cuatrimestre ;
        }
    }
}
