using System;
using System.Collections.Generic;
using System.Text;

namespace ConversionDeMoneda
{
    class ConversionCambiaria
    {
        public decimal PasajeDeMoneda (decimal MonedaNacional, decimal MonedaExtrangera)
        {
            return MonedaNacional / MonedaExtrangera;
        }
    }
}
