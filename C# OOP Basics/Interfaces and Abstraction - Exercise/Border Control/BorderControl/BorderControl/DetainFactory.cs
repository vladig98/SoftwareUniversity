using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class DetainFactory
    {
        public string detainSymbol { get; private set; }

        public DetainFactory(string detainSymbol)
        {
            this.detainSymbol = detainSymbol;
        }

        public bool ShouldDetain(ICitizen citizen)
        {
            return citizen.id.EndsWith(this.detainSymbol);
        }
    }
}
