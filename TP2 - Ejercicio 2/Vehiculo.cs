using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP2.Ejercicio2
{
    class Vehiculo 
    {
        private string marca;
        private string modelo;
        private int anio;
        private string tdv;

        public string Marca { get { return marca; } set { marca = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }
        public int Anio { get { return anio; } set { anio = value; } }
        public string Tdv { get { return tdv; } set { tdv = value; } }

    }
}
