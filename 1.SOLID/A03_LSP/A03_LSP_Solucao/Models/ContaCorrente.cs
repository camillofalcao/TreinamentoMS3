using System;
using System.Collections.Generic;
using System.Text;

namespace A03_LSP_Solucao.Models
{
    public class ContaCorrente : Conta
    {
        public double Limite { get; set; }
        
        public override void Sacar(double valor)
        {
            if (Saldo + Limite < valor)
                throw new Exception("Saldo insuficiente.");

            Saldo -= valor;
        }
    }
}
