using A02_OCP_Problema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Problema.Views
{
    public class ContaView
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
                    case 3:
                        ImprimeSaldo();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

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

            try
            {
                conta.Sacar(valor);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Não foi possível realizar o saque.\n{ex.Message}");
            }
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
