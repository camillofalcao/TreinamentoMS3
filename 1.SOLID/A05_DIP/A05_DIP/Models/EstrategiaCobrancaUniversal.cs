using System;
using System.Collections.Generic;
using System.Text;

namespace A05_DIP.Models
{
    class EstrategiaCobrancaUniversal : IEstrategiaCobranca
    {
        public double RetornaValor(Conta conta)
        {
            return 10;
        }
    }
}

