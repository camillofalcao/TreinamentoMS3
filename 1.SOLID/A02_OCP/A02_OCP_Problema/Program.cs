﻿using A02_OCP_Problema.Models;
using A02_OCP_Problema.Views;
using System;

namespace A02_OCP_Problema
{
    public class Program
    {
        static void Main(string[] args)
        {
            Correntista joao = RetornarCorrentista();
            Conta conta = RetornarConta(joao);

            var viewConta = new ContaView(conta);
            viewConta.Apresentar();

            Console.WriteLine("Fim do programa. Tecle <Enter> para sair.");
            Console.ReadKey();
        }

        private static Conta RetornarConta(Correntista joao)
        {
            return new Conta
            {
                Numero = "123",
                Correntista = joao,
                ValorMaximoSaque = 100,
                Tipo = ETipoConta.Conta_Mesada
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
