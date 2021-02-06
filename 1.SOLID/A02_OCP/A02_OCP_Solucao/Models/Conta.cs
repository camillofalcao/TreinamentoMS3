using System;

/*
    Existem propriedades que propositalmente não foram realocadas.
    Vamos falar sobre elas na próxima aula.
*/
namespace A02_OCP_Solucao.Models
{
    abstract public class Conta
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
