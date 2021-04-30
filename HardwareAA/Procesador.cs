using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAA
{
    class Procesador
    {
        string modelo;
        int numeroDeNulcleos;
        string Zocalo;
        int numeroDeHilos;
        float frecuenciaDelReloj;

        public Procesador(string modelo, int numeroDeNulcleos, string zocalo, int numeroDeHilos, float frecuenciaDelReloj)
        {
            this.modelo = modelo;
            this.numeroDeNulcleos = numeroDeNulcleos;
            Zocalo = zocalo;
            this.numeroDeHilos = numeroDeHilos;
            this.frecuenciaDelReloj = frecuenciaDelReloj;
        }
    }
}
