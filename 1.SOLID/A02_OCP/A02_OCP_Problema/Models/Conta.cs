using System;

namespace A02_OCP_Solucao.Models
{
    public class Conta
    {
        public Correntista Correntista { get; set; }
        public string Numero { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public ETipoConta Tipo { get; set; }
        public double ValorMaximoSaque { get; set; }

        public void Depositar(double valor)
        {   
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (Tipo == ETipoConta.Corrente)
            {
                if (Saldo + Limite < valor)
                    throw new Exception("Saldo insuficiente.");
            }
            else
            {
                if (Saldo < valor)
                    throw new Exception("Saldo insuficiente.");

                if (Tipo == ETipoConta.Conta_Mesada && valor > ValorMaximoSaque)
                    throw new Exception("Você ultrapassou o valor máximo para saque.");
            }

            Saldo -= valor;
        }
    }

    public enum ETipoConta
    {
        Corrente = 0,
        Poupança = 1,
        Conta_Mesada = 2
    }
}
