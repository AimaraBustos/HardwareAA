using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAA
{
    class Monitores
    {
        string tamano;
        string resolucion;
        string consumo;

        public Monitores(string tamano, string resolucion, string consumo)
        {
            this.tamano = tamano;
            this.resolucion = resolucion;
            this.consumo = consumo;
        }
    }
}
