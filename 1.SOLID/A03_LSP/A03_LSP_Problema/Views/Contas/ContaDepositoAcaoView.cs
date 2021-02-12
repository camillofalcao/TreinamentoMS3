using A03_LSP_Problema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A03_LSP_Problema.Views.Contas
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
