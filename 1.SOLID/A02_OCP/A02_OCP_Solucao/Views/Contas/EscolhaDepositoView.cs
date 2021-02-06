using A02_OCP_Solucao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Solucao.Views.Contas
{
    class EscolhaDepositoView : IEscolhaOpcao
    {
        public EscolhaDepositoView(Conta conta) => this.conta = conta;

        public string Descricao => "Depósito";
        
        public void Acao()
        {
            Console.Write("Informe o valor a ser depositado: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            conta.Depositar(valor);
        }

        private readonly Conta conta;
    }
}
