using A02_OCP_Solucao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Solucao.Views.Contas
{
    class EscolhaSaqueView : IEscolhaOpcao
    {
        public EscolhaSaqueView(Conta conta) => this.conta = conta;

        public string Descricao => "Saque";
        
        public void Acao()
        {
            Console.Write("Informe o valor do saque: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            try
            {
                conta.Sacar(valor);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível realizar o saque.\n{ex.Message}");
            }
        }

        private readonly Conta conta;
    }
}
