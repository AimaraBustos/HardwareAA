using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAA
{
    class FuentesDePoder
    {
        string marca;
        int potencia;
        string tamaño;

        public FuentesDePoder(string marca, int potencia, string tamaño)
        {
            this.marca = marca;
            this.potencia = potencia;
            this.tamaño = tamaño;
        }
    }
}
