using System;
using System.Collections.Generic;
using System.Text;

namespace A02_OCP_Problema.Views
{
    interface IAcaoView<T>
    {
        public string Descricao { get; }
        public Action<T> Acao { get; }
    }
}
