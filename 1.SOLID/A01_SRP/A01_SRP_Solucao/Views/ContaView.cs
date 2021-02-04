using A01_SRP_Solucao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A01_SRP_Solucao.Views
{
    class ContaView
    {
        public ContaView(Conta conta) => this.conta = conta;

        public void Apresentar()
        {
            int opcao = LeOpcao();

            while (opcao != 9)
            {
                switch (opcao)
                {
                    case 1:
                        Depositar();
                        break;
                    case 2:
                        Sacar();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                ImprimeSaldo();

                opcao = LeOpcao();
            }
        }

        private void ImprimeSaldo()
        {
            Console.WriteLine($"Saldo: {conta.Saldo:C2}, limite: {conta.Limite:C2}\n");
        }

        private void Sacar()
        {
            Console.Write("Informe o valor do saque: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            conta.Sacar(valor);
        }

        private void Depositar()
        {
            Console.Write("Informe o valor a ser depositado: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            conta.Depositar(valor);
        }

        private int LeOpcao()
        {
            Console.WriteLine("Opções:");
            Console.WriteLine("1) Depósito");
            Console.WriteLine("2) Saque");
            Console.WriteLine("9) Finalizar o programa");
            Console.Write("Sua escolha: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private Conta conta;
    }
}
