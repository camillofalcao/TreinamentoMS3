using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Solucao.Models
{
    class ContaMesada : Conta
    {
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
