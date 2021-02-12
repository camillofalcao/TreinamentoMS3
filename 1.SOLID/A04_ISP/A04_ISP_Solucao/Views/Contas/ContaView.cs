using A04_ISP_Solucao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A04_ISP_Solucao.Views.Contas
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
