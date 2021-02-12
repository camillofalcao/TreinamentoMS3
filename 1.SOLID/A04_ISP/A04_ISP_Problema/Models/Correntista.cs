using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A04_ISP_Problema.Models
{
    public class Correntista : ITarifavelValidavel
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        public void CobrarTarifa(double valor)
        {
            throw new NotImplementedException();
        }

        public bool Validar(out IEnumerable<string> mensagens)
        {
            mensagens = RetornarMensagensValidacao();

            return mensagens.Count() == 0;
        }

        private IEnumerable<string> RetornarMensagensValidacao()
        {
            if (Nome == null || Nome.Length < 3)
                yield return "Nome inválido!";

            if (Telefone == null || Telefone.Length < 10)
                yield return "Telefone inválido!";
        }
    }
}
