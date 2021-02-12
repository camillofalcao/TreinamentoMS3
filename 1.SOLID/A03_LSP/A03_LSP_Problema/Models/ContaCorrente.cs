using System;
using System.Collections.Generic;
using System.Text;

namespace A03_LSP_Problema.Models
{
    public class ContaCorrente : Conta
    {
        public override double ValorMaximoSaque
        {
            get => 0.0;
            set => throw new Exception("Não é possível atribuir um valor máximo para saque a uma conta do tipo corrente.");
        }

        public override void Sacar(double valor)
        {
            if (Saldo + Limite < valor)
                throw new Exception("Saldo insuficiente.");

            Saldo -= valor;
        }
    }
}
