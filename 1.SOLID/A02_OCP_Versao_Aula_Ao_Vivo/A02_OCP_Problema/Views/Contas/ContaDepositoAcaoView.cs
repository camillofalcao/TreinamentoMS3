using A02_OCP_Problema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Problema.Views.Contas
{
    class ContaDepositoAcaoView : IAcaoView<Conta>
    {
        public string Descricao => "Depósito";
        public Action<Conta> Acao => Depositar;

        private void Depositar(Conta conta)
        {
            Console.Write("Informe o valor a ser depositado: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            conta.Depositar(valor);
        }
    }
}
