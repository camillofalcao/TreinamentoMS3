using A04_ISP_Problema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A04_ISP_Problema.Views.Contas
{
    class ContaImprimeSaldoAcaoView : IAcaoView<Conta>
    {
        public string Descricao => "Imprime Saldo";

        public void Acao(Conta obj)
        {
            Console.WriteLine($"Saldo: {obj.Saldo:C2}\n");
        }
    }
}
