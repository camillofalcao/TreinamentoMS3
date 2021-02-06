using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Solucao.Views
{
    public class EscolhaView
    {
        public EscolhaView(IEscolhaOpcao[] opcoes) => this.opcoes = opcoes;
        
        public void Apresentar()
        {
            int opcao = LeOpcao();
            int SAIR = opcoes.Length + 1;

            while (opcao != SAIR)
            {
                if (opcao < 1 || opcao > opcoes.Length)
                    Console.WriteLine("Opção inválida!");
                else
                    opcoes[opcao - 1].Acao();

                opcao = LeOpcao();
            }
        }

        private int LeOpcao()
        {
            int i;
            
            Console.WriteLine("Opções:");

            for (i = 0; i < opcoes.Length; i++)
                Console.WriteLine($"{i + 1}) {opcoes[i].Descricao}");
            
            Console.WriteLine($"{i + 1}) Finalizar o programa");

            Console.Write("Sua escolha: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private readonly IEscolhaOpcao[] opcoes;
    }
}
