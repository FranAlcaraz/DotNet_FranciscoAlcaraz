using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP2.Ejercicio2
{
    class CajadeCambios : ICajadeCambios
    {
        private int cdc;
        private string tdc;

        public string Tipo {
            
            get {
                return tdc;
                }
            set
            {
               tdc = value;
            }
        }
        public int CantidadCambios {
            get
            {
                return cdc;
            }
            set
            {
                cdc = value;
            }
        }
    }
}
