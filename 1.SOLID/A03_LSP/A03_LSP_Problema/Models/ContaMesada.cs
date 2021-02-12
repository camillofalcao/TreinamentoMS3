using System;
using System.Collections.Generic;
using System.Text;

namespace A03_LSP_Problema.Models
{
    public class ContaMesada : Conta
    {
        public override double Limite
        {
            get => 0.0;
            set => throw new Exception("Não é possível atribuir um limite a uma conta do tipo mesada.");
        }
        
        public override void Sacar(double valor)
        {
            if (Saldo < valor)
                throw new Exception("Saldo insuficiente.");

            if (valor > ValorMaximoSaque)
                throw new Exception("Você ultrapassou o valor máximo para saque.");

            Saldo -= valor;
        }
    }
}
