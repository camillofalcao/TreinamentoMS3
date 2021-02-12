using System;
using System.Collections.Generic;
using System.Text;

namespace A04_ISP_Problema.Models
{
    public class ContaMesada : Conta
    {
        public double ValorMaximoSaque { get; set; }

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
