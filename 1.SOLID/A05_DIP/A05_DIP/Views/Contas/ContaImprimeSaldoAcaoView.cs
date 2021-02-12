using A05_DIP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A05_DIP.Views.Contas
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
