using System;
using System.Collections.Generic;
using System.Text;

namespace A04_ISP_Problema.Views
{
    class EscolhaView<T>
    {
        public EscolhaView(IAcaoView<T>[] acoes) => this.acoes = acoes;

        public void Apresentar(T obj)
        {
            int SAIR = acoes.Length + 1;
            int opcao = LeOpcao();

            while (opcao != SAIR)
            {
                if (opcao < 1 || opcao > acoes.Length + 1)
                    Console.WriteLine("Opção inválida!");
                else
                    acoes[opcao - 1].Acao(obj);

                opcao = LeOpcao();
            }
        }

        private int LeOpcao()
        {
            Console.WriteLine("Opções:");

            for (int i = 0; i < acoes.Length; i++)
                Console.WriteLine($"{i + 1}) {acoes[i].Descricao}");
            
            Console.WriteLine($"{acoes.Length + 1}) Finalizar o programa");

            Console.Write("Sua escolha: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private IAcaoView<T>[] acoes;
    }
}
