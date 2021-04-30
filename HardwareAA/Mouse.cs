using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAA
{
    class Mouse
    {
        string marca;
        int DPI;
        Boolean RGB;
        Boolean Inalambrico;

        public Mouse(string marca, int dPI, bool rGB, bool inalambrico)
        {
            this.marca = marca;
            DPI = dPI;
            RGB = rGB;
            Inalambrico = inalambrico;
        }
    }
}
