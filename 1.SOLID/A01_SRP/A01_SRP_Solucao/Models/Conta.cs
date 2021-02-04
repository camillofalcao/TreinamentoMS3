using System;

namespace A01_SRP_Solucao.Models
{
    class Conta
    {
        public Correntista Correntista { get; set; }
        public string Numero { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public void Depositar(double valor)
        {   
            Saldo += valor;
        }

        public void Sacar(double valor)
        {   
            if (Saldo + Limite < valor)
                throw new Exception("Saldo insuficiente.");

            Saldo -= valor;
        }
    }
}
