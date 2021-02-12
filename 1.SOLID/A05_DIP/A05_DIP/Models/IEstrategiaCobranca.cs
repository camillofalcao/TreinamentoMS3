using System;
using System.Collections.Generic;
using System.Text;

namespace A05_DIP.Models
{
    public interface IEstrategiaCobranca
    {
        double RetornaValor(Conta conta);
    }
}
