using Microsoft.AspNetCore.Mvc;
using gestorFinanceiro.Models;

namespace gestorFinanceiro.Controllers;

[ApiController]
[Route("[controller]")]
public class TipoContaController : Controller 
{
    private static readonly List<TipoConta> listTiposConta = new List<TipoConta>
    {
        new TipoConta { Id = 1, IdUsuario = 2, Descricao = "Poupança", Situacao = true },
        new TipoConta { Id = 2, IdUsuario = 2, Descricao = "Corrente", Situacao = true }
    };

    [HttpGet(Name = "GetTiposConta")]
    public List<TipoConta> Get()
    {
        return listTiposConta;
    }

    [HttpGet("{id:int}")]
    public TipoConta Get(int id)
    {
        return listTiposConta.Find(x => x.Id == id);
    }
}