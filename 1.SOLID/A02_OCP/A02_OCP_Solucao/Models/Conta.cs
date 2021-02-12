using System;

namespace A02_OCP_Solucao.Models
{
    public abstract class Conta
    {
        public Correntista Correntista { get; set; }
        public string Numero { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public double ValorMaximoSaque { get; set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public abstract void Sacar(double valor);
    }
}
