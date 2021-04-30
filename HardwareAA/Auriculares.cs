using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAA
{
    class Auriculares
    {
        string marca;
        string potencia;
        string frecuenciaRespuesta;
        Boolean RGB;
        Boolean inalambrico;

        public Auriculares(string marca, string potencia, string frecuenciaRespuesta, bool rGB, bool inalambrico)
        {
            this.marca = marca;
            this.potencia = potencia;
            this.frecuenciaRespuesta = frecuenciaRespuesta;
            RGB = rGB;
            this.inalambrico = inalambrico;
        }
    }
}
