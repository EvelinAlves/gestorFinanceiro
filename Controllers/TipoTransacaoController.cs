using Microsoft.AspNetCore.Mvc;
using gestorFinanceiro.Models;

namespace gestorFinanceiro.Controllers;

[ApiController]
[Route("[controller]")]
public class TipoTransacaoController : Controller
{
    private static readonly List<TipoTransacao> listTiposTransacao = new List<TipoTransacao>
    {
        new TipoTransacao { Id = 1, IdUsuario = 1, Descricao = "Entrada", Situacao =  true },
        new TipoTransacao { Id = 2, IdUsuario = 1, Descricao = "Saida", Situacao =  true },
        new TipoTransacao { Id = 3, IdUsuario = 1, Descricao = "Credito", Situacao =  true }
    };

    [HttpGet(Name = "GetTiposTransacao")]
    public List<TipoTransacao> Get()
    {
        return listTiposTransacao;
    }

    [HttpGet("{id:int}")]
    public TipoTransacao Get(int id)
    {
        return listTiposTransacao.Find(x => x.Id == id);
    }

}