using Microsoft.AspNetCore.Mvc;
using gestorFinanceiro.Models;

namespace gestorFinanceiro.Controllers;

[ApiController]
[Route("[controller]")]
public class LancamentoCartaoCreditoController : Controller 
{
    private static readonly List<LancamentoCartaoCredito> listLancamentosCartaoCredito = new List<LancamentoCartaoCredito> 
    {
        new LancamentoCartaoCredito { Id = 1, IdUsuario = 2, IdCartaoCredito = 1, IdCategoria = 3, IdTipoTransacao = 3, IdTipoSituacaoTransacao = 1, DataTransacao = new DateTime(), Descricao = "Amazon - Livros" },
        new LancamentoCartaoCredito { Id = 2, IdUsuario = 2, IdCartaoCredito = 1, IdCategoria = 3, IdTipoTransacao = 3, IdTipoSituacaoTransacao = 1, DataTransacao = new DateTime(), Descricao = "Amazon - Monitor" },
        new LancamentoCartaoCredito { Id = 3, IdUsuario = 2, IdCartaoCredito = 1, IdCategoria = 3, IdTipoTransacao = 3, IdTipoSituacaoTransacao = 1, DataTransacao = new DateTime(), Descricao = "Amazon - Geladeira" },
        new LancamentoCartaoCredito { Id = 4, IdUsuario = 2, IdCartaoCredito = 1, IdCategoria = 3, IdTipoTransacao = 3, IdTipoSituacaoTransacao = 1, DataTransacao = new DateTime(), Descricao = "Amazon - Cadeira " },
        new LancamentoCartaoCredito { Id = 5, IdUsuario = 2, IdCartaoCredito = 1, IdCategoria = 3, IdTipoTransacao = 3, IdTipoSituacaoTransacao = 1, DataTransacao = new DateTime(), Descricao = "Amazon - Tv" },
    };

    [HttpGet(Name = "GetLancamentosCartaoCredito")]
    public List<LancamentoCartaoCredito> Get()
    {
        return listLancamentosCartaoCredito;
    }

    [HttpGet("{id:int}")]
    public LancamentoCartaoCredito Get(int id)
    {
        return listLancamentosCartaoCredito.Find( x => x.Id == id);
    }
}