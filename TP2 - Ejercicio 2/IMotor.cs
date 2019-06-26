using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP2.Ejercicio2
{
    interface IMotor
    {
        int Cilindradas {
            get;
            set;
        }
        string Iniciar
        {
            get;
        }
        string Frenar
        {
            get;
        }
    }
}
