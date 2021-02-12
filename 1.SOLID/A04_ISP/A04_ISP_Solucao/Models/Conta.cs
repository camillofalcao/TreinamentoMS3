using System;
using System.Collections.Generic;

namespace A04_ISP_Solucao.Models
{
    abstract public class Conta : IValidavel, ITarifavel
    {
        public Correntista Correntista { get; set; }
        public string Numero { get; set; }
        public double Saldo { get; set; }

        public void Depositar(double valor)
        {   
            Saldo += valor;
        }

        public abstract void Sacar(double valor);

        public void CobrarTarifa(double valor)
        {
            Saldo -= valor;
        }
        
        public bool Validar(out IEnumerable<string> mensagens)
        {
            mensagens = RetornarMensagensValidacao();
            
            return mensagens != null;
        }

        public IEnumerable<string> RetornarMensagensValidacao()
        {
            if (Correntista == null)
                yield return "Correntista inválido!";

            if (Numero.Length < 1)
                yield return "Número inválido!";
        }
    }
}
