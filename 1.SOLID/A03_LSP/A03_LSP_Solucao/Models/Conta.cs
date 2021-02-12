using System;

/*
    Existem propriedades que propositalmente não foram realocadas.
    Vamos falar sobre elas na próxima aula.
*/
namespace A03_LSP_Solucao.Models
{
    abstract public class Conta
    {
        public Correntista Correntista { get; set; }
        public string Numero { get; set; }
        public double Saldo { get; set; }
        
        public void Depositar(double valor)
        {   
            Saldo += valor;
        }

        public abstract void Sacar(double valor);
    }
}
