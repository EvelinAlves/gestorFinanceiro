using Microsoft.AspNetCore.Mvc;
using gestorFinanceiro.Models;

namespace gestorFinanceiro.Controllers;

[ApiController]
[Route("[controller]")]
public class BancoController : ControllerBase
{
    private static readonly List<Banco> listaBancos = new List<Banco>
    {
        new Banco { Id = 1, IdUsuario = 1, Descricao = "Santander", Situacao = true },
        new Banco { Id = 2, IdUsuario = 2, Descricao = "Bradesco", Situacao = true },
        new Banco { Id = 3, IdUsuario = 1, Descricao = "NuBank", Situacao = true },
        new Banco { Id = 4, IdUsuario = 4, Descricao = "Banco do Brasil", Situacao = true },
        new Banco { Id = 5, IdUsuario = 3, Descricao = "Caixa Econômica Federal", Situacao = true },
        new Banco { Id = 6, IdUsuario = 1, Descricao = "Banco Desativado", Situacao = false },
    };

    [HttpGet(Name = "GetBancos")]
    public List<Banco> Get()
    {
        return listaBancos;
    }

    [HttpGet("{id:int}")]
    public Banco Get(int id)
    {
        Banco banco = listaBancos.Find(x => x.Id == id );
        return banco;
    }

}