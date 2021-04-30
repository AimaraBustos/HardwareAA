using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAA
{
    public class PlacasBase
    {
        string marca;
        string formatosDePlaca;
        int ranuras;
        int conectoresDeAlimentacion;

        public PlacasBase(string marca, string formatosDePlaca, int ranuras, int conectoresDeAlimentacion)
        {
            this.marca = marca;
            this.formatosDePlaca = formatosDePlaca;
            this.ranuras = ranuras;
            this.conectoresDeAlimentacion = conectoresDeAlimentacion;
        }
    }
}
