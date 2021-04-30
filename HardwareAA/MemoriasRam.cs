using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAA
{
    class MemoriasRam
    {
       string marca;
       string tipoDeMemoria;
       int almacenamiento;
       string TipoDePuerto;
       string FrecuenciaMemoria;

        public MemoriasRam(string marca, string tipoDeMemoria, int almacenamiento, string tipoDePuerto, string frecuenciaMemoria)
        {
            this.marca = marca;
            this.tipoDeMemoria = tipoDeMemoria;
            this.almacenamiento = almacenamiento;
            TipoDePuerto = tipoDePuerto;
            FrecuenciaMemoria = frecuenciaMemoria;
        }
    }
}
