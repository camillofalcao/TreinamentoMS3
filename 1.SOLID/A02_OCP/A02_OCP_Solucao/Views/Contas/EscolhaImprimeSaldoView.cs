using A02_OCP_Solucao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Solucao.Views.Contas
{
    class EscolhaImprimeSaldoView : IEscolhaOpcao
    {
        public EscolhaImprimeSaldoView(Conta conta) => this.conta = conta;

        public string Descricao => "Imprime Saldo";

        public void Acao()
        {
            Console.WriteLine($"Saldo: {conta.Saldo:C2}, limite: {conta.Limite:C2}\n");
        }

        private readonly Conta conta;
    }
}
