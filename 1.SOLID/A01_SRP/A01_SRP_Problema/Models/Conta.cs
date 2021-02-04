using System;

/*
    ATENÇÃO: esse código está propositalmente ruim.
    Você deve tentar melhorá-lo utilizando para isso 
    o princípio SRP.
*/

namespace A01_SRP_Problema.Models
{
    class Conta
    {
        public string CorrentistaNome { get; set; }
        public string CorrentistaTelefone { get; set; }
        public string CorrentistaCpf { get; set; }

        public string Numero { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public void Depositar()
        {
            Console.Write("Informe o valor a ser depositado: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            Saldo += valor;
        }

        public void Sacar()
        {
            Console.Write("Informe o valor do saque: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (Saldo + Limite < valor)
                throw new Exception("Saldo insuficiente.");

            Saldo -= valor;
        }
    }
}
