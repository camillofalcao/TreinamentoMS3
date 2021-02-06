using A02_OCP_Solucao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Solucao.Views.Contas
{
    public class ContaView
    {
        public ContaView(Conta conta) => this.conta = conta;

        public void Apresentar()
        {
            var opcoes = new IEscolhaOpcao[]
            {
                new EscolhaDepositoView(conta),
                new EscolhaSaqueView(conta),
                new EscolhaImprimeSaldoView(conta)
            };

            var escolha = new EscolhaView(opcoes);
            escolha.Apresentar();
        }

        private readonly Conta conta;
    }
}
