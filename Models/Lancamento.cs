using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestorFinanceiro.Models
{
    public class Lancamento
    {
        public int Codigo { get; }
        public int CodUsuario { get; set; }
        public int CodTipoTransacao { get; set; }
        public int CodTipoSituacaoTransacao { get; set; }
        public int CodCategoria { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataTransacao { get; set; }
        public bool DespesaFixa { get; set; }
        public string? Descricao { get; set; }
        public int CodigoRelacao { get; set; }
        
        
    }
}