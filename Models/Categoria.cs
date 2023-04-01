using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestorFinanceiro.Models
{
    public class Categoria
    {
        public int Codigo { get; }
        public int CodUsuario { get; set; }
        public string? Descricao { get; set; }
        public bool Situacao { get; set; }
    }
}