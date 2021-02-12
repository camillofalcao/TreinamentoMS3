using A03_LSP_Problema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A03_LSP_Problema.Views.Contas
{
    public class ContaView
    {
        public ContaView()
        {
            this.acoes = new IAcaoView<Conta>[]
            {
                new ContaDepositoAcaoView(),
                new ContaSaqueAcaoView(),
                new ContaImprimeSaldoAcaoView(),
                new ContaImprimeExtratoAcaoView()
            };
        }

        public void Apresentar(Conta conta)
        {
            var escolhaView = new EscolhaView<Conta>(acoes);
            escolhaView.Apresentar(conta);
        }

        private readonly IAcaoView<Conta>[] acoes;
    }
}
