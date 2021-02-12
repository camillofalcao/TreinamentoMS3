using System;
using System.Collections.Generic;
using System.Text;

namespace A03_LSP_Problema.Models
{
    public class ContaPoupanca : Conta
    {
        public override double Limite 
        { 
            get => 0.0; 
            set => throw new Exception("Não é possível atribuir um limite a uma conta do tipo poupança."); 
        }

        public override double ValorMaximoSaque
        {
            get => 0.0;
            set => throw new Exception("Não é possível atribuir um valor máximo para saque a uma conta do tipo poupança.");
        }

        public override void Sacar(double valor)
        {
            if (Saldo < valor)
                throw new Exception("Saldo insuficiente.");

            Saldo -= valor;
        }
    }
}
