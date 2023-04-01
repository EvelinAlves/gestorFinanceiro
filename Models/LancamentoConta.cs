using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestorFinanceiro.Models
{
    public class LancamentoConta : Lancamento
    {
            public int IdBanco { get; set; }
            public DateTime DataBaixa{ get; set; }

            public LancamentoConta()
                :base()
            {             
            }
    }
}