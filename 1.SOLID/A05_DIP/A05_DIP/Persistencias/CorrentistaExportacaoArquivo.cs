using A05_DIP.Persistencias;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace A05_DIP.Models
{
    class CorrentistaExportacaoArquivo
    {
        public CorrentistaExportacaoArquivo(ICorrentistaExportacao correntistaExportacao) =>
            this.correntistaExportacao = correntistaExportacao;

        public void Exportar(Correntista[] objetos, string caminhoCompletoArquivo)
        {
            File.WriteAllText(caminhoCompletoArquivo, correntistaExportacao.Exportar(objetos));
        }

        private readonly ICorrentistaExportacao correntistaExportacao;
    }
}
