using System;
using System.Collections.Generic;
using System.Text;

namespace A04_ISP_Problema.Models
{
    public interface ITarifavelValidavel
    {
        void CobrarTarifa(double valor);
        bool Validar(out IEnumerable<string> mensagens);
    }
}
