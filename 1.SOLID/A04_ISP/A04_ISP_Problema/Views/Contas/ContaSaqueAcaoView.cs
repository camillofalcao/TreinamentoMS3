using A04_ISP_Problema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A04_ISP_Problema.Views.Contas
{
    class ContaSaqueAcaoView : IAcaoView<Conta>
    {
        public string Descricao => "Saque";

        public void Acao(Conta obj)
        {
            Console.Write("Informe o valor do saque: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            try
            {
                obj.Sacar(valor);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível realizar o saque.\n{ex.Message}");
            }
        }
    }
}
