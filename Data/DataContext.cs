using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public DbSet<ContaFinanceira> ContaFinanceiras { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<LancamentoCartaoCredito> LancamentoCartaoCreditos { get; set; }
        public DbSet<LancamentoConta> LancamentoContas { get; set; }
        public DbSet<SituacaoTransacao> SituacaoTransacoes { get; set; }
        public DbSet<TipoConta> TipoContas { get; set; }
        public DbSet<TipoTransacao> TipoTransacoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
            
    }
}