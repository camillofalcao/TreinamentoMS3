using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Solucao.Models
{
    class ContaCorrente : Conta
    {
        public override void Sacar(double valor)
        {
            if (Saldo + Limite < valor)
                throw new Exception("Saldo insuficiente.");

            Saldo -= valor;
        }
    }
}
