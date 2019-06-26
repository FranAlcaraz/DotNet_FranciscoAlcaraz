using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP2.Ejercicio2
{
    class Ruedas : IRuedas
    {
        int cdr;
        int diametro;

        public int CantidadDeRuedas {
            get { return cdr; }
            set {
                    cdr = value;
            }
        }
        public int Diametro
        {
            get { return diametro; }
            set
            {
                diametro = value;
            }
        }
        public string Iniciar {
            get { return ("El vehiculo comienza a moverse"); }
        }

        public string Frenar
        {
            get { return ("El vehiculo se detiene"); }
        }
    }
}
