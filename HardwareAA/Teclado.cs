using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAA { 
    class Teclado
    {
        string marca;
        string factorForma;
        Boolean RGB;
        string idioma;

        public Teclado(string marca, string factorForma, bool rGB, string idioma)
        {
            this.marca = marca;
            this.factorForma = factorForma;
            RGB = rGB;
            this.idioma = idioma;
        }
    }
}
