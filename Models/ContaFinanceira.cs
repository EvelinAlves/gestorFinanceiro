using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestorFinanceiro.Models
{
    public class ContaFinanceira
    {
        public long Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdBanco { get; set; }
        public int IdTipoConta { get; set; }
        public decimal Saldo { get; set; }
        public bool Situacao { get; set; }

        public ContaFinanceira()
        { 
        }
        
    }
}