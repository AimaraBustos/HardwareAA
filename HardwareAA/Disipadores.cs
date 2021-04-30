using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAA
{
    class Disipadores
    {
        string marca;
        int RPM;
        string socket;

        public Disipadores(string marca, int rPM, string socket)
        {
            this.marca = marca;
            RPM = rPM;
            this.socket = socket;
        }
    }
}
