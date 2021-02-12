using System;
using System.Collections.Generic;
using System.Text;

namespace A04_ISP_Solucao.Models
{
    public interface IValidavel
    {
        bool Validar(out IEnumerable<string> mensagens);
    }
}
