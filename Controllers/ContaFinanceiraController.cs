using Microsoft.AspNetCore.Mvc;
using gestorFinanceiro.Models;

namespace gestorFinanceiro.Controllers;

[ApiController]
[Route("[controller]")]
public class ContaFinanceiraController : Controller 
{
    private static readonly List<ContaFinanceira> listContasFinanceiras = new List<ContaFinanceira>
    {
        new ContaFinanceira { Id = 1, IdUsuario = 1, IdBanco = 1, IdTipoConta = 1, Saldo = 5000.00M, Situacao = true },
        new ContaFinanceira { Id = 2, IdUsuario = 2, IdBanco = 1, IdTipoConta = 2, Saldo = 5000.00M, Situacao = true },
        new ContaFinanceira { Id = 3, IdUsuario = 4, IdBanco = 2, IdTipoConta = 3, Saldo = 5000.00M, Situacao = true },
        new ContaFinanceira { Id = 4, IdUsuario = 3, IdBanco = 3, IdTipoConta = 1, Saldo = 5000.00M, Situacao = true }
    };

    [HttpGet(Name = "GetContasFinanceiras")]
    public List<ContaFinanceira> Get()
    {
        return listContasFinanceiras;
    }

    [HttpGet("{id:int}")]
    public ContaFinanceira Get(int id)
    {
        return listContasFinanceiras.Find( x => x.Id == id);
    }
}