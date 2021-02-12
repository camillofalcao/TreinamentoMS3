using A02_OCP_Problema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Problema.Views.Contas
{
    class ContaSaqueAcaoView : IAcaoView<Conta>
    {
        public string Descricao => "Saque";

        public Action<Conta> Acao => Sacar;

        private void Sacar(Conta conta)
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
    }
}
