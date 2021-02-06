using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Solucao.Views
{
    public interface IEscolhaOpcao
    {
        public string Descricao { get; }
        public void Acao();
    }
}
