using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestorFinanceiro.Models
{
    public class Lancamento
    {
        public long Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoTransacao { get; set; }
        public int IdTipoSituacaoTransacao { get; set; }
        public int IdCategoria { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataTransacao { get; set; }
        public bool DespesaFixa { get; set; }
        public string? Descricao { get; set; }
        public int CodigoRelacao { get; set; }
        
        public Lancamento()
        {
        }
    }
}