using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3___Ejercicio
{
    public class Nota
    {
        public string tipo;
        private int fecha;
        private int valor;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Acceso()
        {
            return "Tipo de Examen: " + tipo + "\nFecha de Examen: " + fecha + "\nValor de nota: " + valor;
        }
    }
}
