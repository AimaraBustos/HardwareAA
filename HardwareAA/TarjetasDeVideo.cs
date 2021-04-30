using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAA
{
    class TarjetasDeVideo
    {
        string ChipGrafico;
        int MemoriaVideo;
        string Frecuencia;
        String Interfaz;
        int MaxResolucion;

        public TarjetasDeVideo(string chipGrafico, int memoriaVideo, string frecuencia, string interfaz, int maxResolucion)
        {
            ChipGrafico = chipGrafico;
            MemoriaVideo = memoriaVideo;
            Frecuencia = frecuencia;
            Interfaz = interfaz;
            MaxResolucion = maxResolucion;
        }
    }
}
