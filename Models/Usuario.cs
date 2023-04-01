using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestorFinanceiro.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public bool Situacao { get; set; }
        public string? Apelido { get; set; }
        public char Genero { get; set; }
        public int Idade { get; set; }
        public string? EstadoCivil { get; set; }

        public Usuario()
        {
        }
    }
}