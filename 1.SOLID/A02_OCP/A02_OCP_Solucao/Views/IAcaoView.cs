using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Solucao.Views
{
    interface IAcaoView<T>
    {
        string Descricao { get; }
        void Acao(T obj);
    }
}
