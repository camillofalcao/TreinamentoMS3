using A03_LSP_Problema.Models;
using A03_LSP_Problema.Views;
using A03_LSP_Problema.Views.Contas;
using System;

namespace A03_LSP_Problema
{
    public class Program
    {
        static void Main(string[] args)
        {
            Correntista joao = RetornarCorrentista();
            Conta conta = RetornarConta(joao);

            var viewConta = new ContaView();
            viewConta.Apresentar(conta);

            Console.WriteLine("Fim do programa. Tecle <Enter> para sair.");
            Console.ReadKey();
        }

        private static Conta RetornarConta(Correntista joao)
        {
            return new ContaMesada
            {
                Numero = "123",
                Correntista = joao,
                ValorMaximoSaque = 100
            };
        }

        private static Correntista RetornarCorrentista()
        {
            return new Correntista
            {
                Cpf = "111.111.111.11",
                Telefone = "88-98888-8888",
                Nome = "João",
            };
        }
    }
}
