using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestorFinanceiro.Models
{
    public class Banco
    {
        public long Id { get; set; }
        public int IdUsuario { get; set; }
        public string? Descricao { get; set; }
        public bool Situacao { get; set; }

        public Banco()
        {
        }
    }
}