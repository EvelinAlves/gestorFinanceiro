using Microsoft.EntityFrameworkCore;

namespace gestorFinanceiro.Models;

public class UsuarioContext : DbContext
{
    public UsuarioContext(DbContextOptions<UsuarioContext> options)
        : base(options)
    {
    }

    public DbSet<UsuarioContext> usuarioContexts { get; set; } = null!;
}