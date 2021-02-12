using A05_DIP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A05_DIP.Persistencias
{
    class CorrentistaExportacaoCsv : ICorrentistaExportacao
    {
        public string Exportar(Correntista[] objetos)
        {
            var conteudo = new StringBuilder();

            foreach (var obj in objetos)
                conteudo.Append(ExportarLinhaCsv(obj) + "\n");

            return conteudo.ToString();
        }

        private string ExportarLinhaCsv(Correntista correntista)
        {
            return correntista.Nome +
                ";" + correntista.Cpf +
                ";" + correntista.Telefone;
        }
    }
}
