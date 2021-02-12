using A03_LSP_Solucao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A03_LSP_Solucao.Views.Contas
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
