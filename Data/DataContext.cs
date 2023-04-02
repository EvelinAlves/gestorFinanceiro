using gestorFinanceiro.Models;
using Microsoft.EntityFrameworkCore;

namespace gestorFinanceiro.Data
{
    public class DataContext : DbContext
    {

        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string connectionString = Configuration.GetConnectionString("MySQLConnection");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    

        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ContaFinanceira> ContasFinanceiras { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<LancamentoCartaoCredito> LancamentosCartaoCredito { get; set; }
        public DbSet<LancamentoConta> LancamentosConta { get; set; }
        public DbSet<SituacaoTransacao> SituacoesTransacao { get; set; }
        public DbSet<TipoConta> TiposConta { get; set; }
        public DbSet<TipoTransacao> TiposTransacao { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
            
    }
}