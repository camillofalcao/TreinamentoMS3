using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Problema.Models
{
    class ContaPoupanca : Conta
    {
        public override void Sacar(double valor)
        {
            if (Saldo < valor)
                throw new Exception("Saldo insuficiente.");
            
            Saldo -= valor;
        }
    }
}
