using A05_DIP.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace A05_DIP.Persistencias
{
    class CorrentistaExportacaoJson : ICorrentistaExportacao
    {
        public string Exportar(Correntista[] objetos)
        {
            return JsonConvert.SerializeObject(objetos);
        }
    }
}
