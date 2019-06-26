using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP2.Ejercicio2
{
    class Motor : IMotor
    {
        private int cilindradas;

        public int Cilindradas
        {
            get
            {
                return cilindradas;
            }
            set
            {
                cilindradas = value;
            }
        }
        public string Iniciar
        {
            get
            {
                return ("El motor se pone en marcha");
            }
        }
        public string Frenar
        {
            get
            {
                return ("Se apaga el motor");
            }
        }
    }
}
