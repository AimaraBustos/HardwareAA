using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAA
{
    class Ventiladores
    {
        string marca;
        string velocidad;

        public Ventiladores(string marca, string velocidad)
        {
            this.marca = marca;
            this.velocidad = velocidad;
        }
    }
}
