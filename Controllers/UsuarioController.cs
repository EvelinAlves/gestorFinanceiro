using Microsoft.AspNetCore.Mvc;
using gestorFinanceiro.Models;
using Microsoft.AspNetCore.Cors;

namespace gestorFinanceiro.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : Controller
{
    private static readonly List<Usuario> listaUsuarios = new List<Usuario>
    {
        new Usuario { Id = 1, Apelido = "Evelin", Cpf = "11111111111", Email = "evelin@email.com.br", EstadoCivil = "solteira", Genero = 'F', Idade = 34, Nome = "Evelin Alves", Senha = "123456789", Situacao = true  },
        new Usuario { Id = 2, Apelido = "Maria", Cpf = "22222222222", Email = "maria@email.com.br", EstadoCivil = "casada", Genero = 'F', Idade = 20, Nome = "Maria Alves", Senha = "123789456", Situacao = true  },
        new Usuario { Id = 3, Apelido = "Joao", Cpf = "33333333333", Email = "joao@email.com.br", EstadoCivil = "divorciado", Genero = 'M', Idade = 50, Nome = "Joao Alves", Senha = "321654987", Situacao = true  },
        new Usuario { Id = 4, Apelido = "Regina", Cpf = "44444444444", Email = "regina@email.com.br", EstadoCivil = "viuva", Genero = 'F', Idade = 18, Nome = "Regina Alves", Senha = "987654321", Situacao = false  }
    };

    [EnableCors("AnotherPolicy")] 
    [HttpGet(Name = "GetUsuarios")]
    public List<Usuario> Get()
    {
        return listaUsuarios;
    }

    [EnableCors("AnotherPolicy")] 
    [HttpGet("{id:int}")]
    public Usuario Get(int id)
    {
        Usuario usuario = listaUsuarios.Find( x => x.Id == id );
        return usuario;
    }
}