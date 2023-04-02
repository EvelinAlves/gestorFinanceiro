using Microsoft.AspNetCore.Mvc;
using gestorFinanceiro.Models;

namespace gestorFinanceiro.Controllers;

[ApiController]
[Route("[controller]")]
public class SituacaoTransacaoController : ControllerBase
{
    private static readonly List<SituacaoTransacao> listSituacoesTransacoes = new List<SituacaoTransacao> 
    {
        new SituacaoTransacao { Id = 1, IdUsuario = 1, Descricao = "CANCELADA", Situacao = true },
        new SituacaoTransacao { Id = 2, IdUsuario = 1, Descricao = "ESTORNADA", Situacao = true },
        new SituacaoTransacao { Id = 3, IdUsuario = 1, Descricao = "BAIXADA", Situacao = true },
        new SituacaoTransacao { Id = 4, IdUsuario = 1, Descricao = "PENDENTE", Situacao = true }
    };

    [HttpGet(Name = "GetSituacoesTransacao")]
    public List<SituacaoTransacao> Get()
    {
        return listSituacoesTransacoes;
    }

    [HttpGet("{id:int}")]
    public SituacaoTransacao Get(int id)
    {
        return listSituacoesTransacoes.Find(x => x.Id == id);
    }
}