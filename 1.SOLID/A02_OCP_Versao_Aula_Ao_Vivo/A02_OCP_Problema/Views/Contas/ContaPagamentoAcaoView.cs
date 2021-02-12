using A02_OCP_Problema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Problema.Views.Contas
{
    class ContaPagamentoAcaoView : IAcaoView<Conta>
    {
        public string Descricao => "Pagamento";

        public Action<Conta> Acao => Pagar;

        private void Pagar(Conta conta)
        {
            Console.Write("Informe o valor da conta: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            conta.Sacar(valor);
        }
    }
}
