using A01_SRP_Problema.Models;
using System;

namespace A01_SRP_Problema
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta
            {
                Numero = "123",
                CorrentistaCpf = "111.111.111.11",
                CorrentistaTelefone = "88-98888-8888",
                CorrentistaNome = "João",
                Limite = 1000
            };

            int opcao = LeOpcao();

            while (opcao != 9)
            {
                switch (opcao)
                {
                    case 1:
                        conta.Depositar();
                        break;
                    case 2:
                        conta.Sacar();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine($"Saldo: {conta.Saldo:C2}, limite: {conta.Limite:C2}\n");

                opcao = LeOpcao();
            }
            
            Console.WriteLine("Fim do programa. Tecle <Enter> para sair.");
            Console.ReadKey();
        }

        private static int LeOpcao()
        {
            Console.WriteLine("Opções:");
            Console.WriteLine("1) Depósito");
            Console.WriteLine("2) Saque");
            Console.WriteLine("9) Finalizar o programa");
            Console.Write("Sua escolha: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
