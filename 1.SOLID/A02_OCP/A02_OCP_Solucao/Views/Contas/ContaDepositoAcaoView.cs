using A02_OCP_Solucao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Solucao.Views.Contas
{
    class ContaDepositoAcaoView : IAcaoView<Conta>
    {
        public string Descricao => "Depósito";

        public void Acao(Conta obj)
        {
            Console.Write("Informe o valor a ser depositado: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            obj.Depositar(valor);
        }
    }
}
