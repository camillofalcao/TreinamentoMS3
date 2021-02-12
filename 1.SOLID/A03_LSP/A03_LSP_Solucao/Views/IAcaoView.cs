using System;
using System.Collections.Generic;
using System.Text;

namespace A03_LSP_Solucao.Views
{
    interface IAcaoView<T>
    {
        string Descricao { get; }
        void Acao(T obj);
    }
}
