using Microsoft.AspNetCore.Mvc;
using gestorFinanceiro.Models;

namespace gestorFinanceiro.Controllers;

[ApiController]
[Route("[controller]")]
public class LancamentoContaController : ControllerBase
{
    private static readonly List<LancamentoConta> listLancamentosConta = new List<LancamentoConta>
    {
        new LancamentoConta { Id = 1, IdUsuario = 1, IdBanco = 2, IdCategoria = 3, IdTipoTransacao = 5, IdTipoSituacaoTransacao = 10, CodigoRelacao = 0, DataTransacao = new DateTime(), Descricao = "Pagamento Aluguel", DespesaFixa = true, Valor = 500.00M, DataBaixa = new DateTime() },
        new LancamentoConta { Id = 2, IdUsuario = 1, IdBanco = 2, IdCategoria = 3, IdTipoTransacao = 5, IdTipoSituacaoTransacao = 10, CodigoRelacao = 0, DataTransacao = new DateTime(), Descricao = "Pagamento Aluguel", DespesaFixa = true, Valor = 500.00M, DataBaixa = new DateTime() },
        new LancamentoConta { Id = 3, IdUsuario = 1, IdBanco = 2, IdCategoria = 3, IdTipoTransacao = 5, IdTipoSituacaoTransacao = 10, CodigoRelacao = 0, DataTransacao = new DateTime(), Descricao = "Pagamento Aluguel", DespesaFixa = true, Valor = 500.00M, DataBaixa = new DateTime() }
    };

    [HttpGet(Name = "GetLancamentosConta")]
    public List<LancamentoConta> Get()
    {
        return listLancamentosConta;
    }

    [HttpGet("{id:int}")]
    public LancamentoConta Get(int id)
    {
        return listLancamentosConta.Find(x => x.Id == id);
    }


}