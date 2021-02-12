using A02_OCP_Problema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Problema.Views.Contas
{
    public class ContaView
    {
        public ContaView(Conta conta) => this.conta = conta;

        public void Apresentar()
        {
            var acoes = new IAcaoView<Conta>[]
            {
                new ContaDepositoAcaoView(),
                new ContaSaqueAcaoView(),
                new ContaImprimeSaldoAcaoView()//,
                //new ContaPagamentoAcaoView()
            };

            var opcoesView = new OpcoesView<Conta>(acoes, conta);

            opcoesView.Apresentar();
        }

        private Conta conta;
    }
}
