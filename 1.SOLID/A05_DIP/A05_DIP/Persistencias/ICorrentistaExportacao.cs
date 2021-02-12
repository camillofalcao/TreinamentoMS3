using A05_DIP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A05_DIP.Persistencias
{
    interface ICorrentistaExportacao
    {
        string Exportar(Correntista[] objetos);
    }
}
