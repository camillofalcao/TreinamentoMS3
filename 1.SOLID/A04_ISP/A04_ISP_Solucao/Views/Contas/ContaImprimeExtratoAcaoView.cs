﻿using A04_ISP_Solucao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A04_ISP_Solucao.Views.Contas
{
    class ContaImprimeExtratoAcaoView : IAcaoView<Conta>
    {
        public string Descricao => "Imprime Extrato";

        public void Acao(Conta obj)
        {
            Console.WriteLine($"Impressão do extrado da conta {obj.Numero}");
        }
    }
}
