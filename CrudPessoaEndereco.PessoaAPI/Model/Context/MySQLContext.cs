using CadastroPessoaEndereco.PessoaAPI.Model;
using Microsoft.EntityFrameworkCore;


namespace CrudPessoaEndereco.PessoaAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public DbSet<Pessoa>? Pessoas { get; set; }
        public DbSet<Endereco>? Enderecos { get; set; }

        protected MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
        }
    }

}


