using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAA
{
    class DiscosDuros
    {

        String Interfaz;
        String Almacenamiento;
        int MemoriaCache;

        public DiscosDuros(string interfaz, string almacenamiento, int memoriaCache)
        {
            Interfaz = interfaz;
            Almacenamiento = almacenamiento;
            MemoriaCache = memoriaCache;
        }
    }
}
