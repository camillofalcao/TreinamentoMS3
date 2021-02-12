using A02_OCP_Problema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Problema.Views.Contas
{
    class ContaImprimeSaldoAcaoView : IAcaoView<Conta>
    {
        public string Descricao => "Imprime Saldo";

        public Action<Conta> Acao => ImprimeSaldo;

        private void ImprimeSaldo(Conta conta)
        {
            Console.WriteLine($"Saldo: {conta.Saldo:C2}, limite: {conta.Limite:C2}\n");
        }
    }
}
