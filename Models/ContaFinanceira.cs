using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestorFinanceiro.Models
{
    public class ContaFinanceira
    {
        public int Codigo { get; }
        public int CodUsuario { get; set; }
        public int CodBanco { get; set; }
        public int CodTipoConta { get; set; }
        public decimal Saldo { get; set; }
        public bool Situacao { get; set; }
        
    }
}