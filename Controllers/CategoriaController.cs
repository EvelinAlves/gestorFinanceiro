using Microsoft.AspNetCore.Mvc;
using gestorFinanceiro.Models;

namespace gestorFinanceiro.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriaController : ControllerBase
{
    private static readonly List<Categoria> listCategorias = new List<Categoria>
    {
        new Categoria { Id = 1, IdUsuario = 1, Descricao = "Compras" },
        new Categoria { Id = 2, IdUsuario = 1, Descricao = "Saúde" },
        new Categoria { Id = 3, IdUsuario = 1, Descricao = "Estudo" },
        new Categoria { Id = 5, IdUsuario = 1, Descricao = "Transporte" },
    };

    [HttpGet(Name = "GetCategoria")]
    public List<Categoria> GetCategorias()
    {
        return listCategorias;
    }

    [HttpGet("{id:int}")]
    public Categoria Get(int id)
    {
        Categoria categoria = listCategorias.Find( x => x.Id == id );
        return categoria;
    }
}