using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestorFinanceiro.Models
{
    public class LancamentoCartaoCredito : Lancamento
    {
         public int CodCartaoCredito { get; set; }
    }
}