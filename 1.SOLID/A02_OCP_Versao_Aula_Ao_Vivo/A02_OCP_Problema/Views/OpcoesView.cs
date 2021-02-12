using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Problema.Views
{
    class OpcoesView<T>
    {
        public OpcoesView(IAcaoView<T>[] acoes, T objeto)
        {
            this.acoes = acoes;
            this.objeto = objeto;
        }

        public void Apresentar()
        {
            int opcao = LeOpcao();
            int SAIR = acoes.Length + 1;

            while (opcao != SAIR)
            {
                if (opcao < 1 || opcao > acoes.Length + 1)
                    Console.WriteLine("Opção inválida!");
                else
                    acoes[opcao - 1].Acao(objeto);

                opcao = LeOpcao();
            }
        }

        private int LeOpcao()
        {
            Console.WriteLine("Opções:");

            for (int i = 0; i < acoes.Length; i++)
                Console.WriteLine($"{i + 1}) {acoes[i].Descricao}");
            
            Console.WriteLine($"{acoes.Length + 1}) Sair");

            Console.Write("Sua escolha: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private IAcaoView<T>[] acoes;
        private T objeto;
    }
}
