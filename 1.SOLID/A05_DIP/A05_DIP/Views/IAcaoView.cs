using System;
using System.Collections.Generic;
using System.Text;

namespace A05_DIP.Views
{
    interface IAcaoView<T>
    {
        string Descricao { get; }
        void Acao(T obj);
    }
}
