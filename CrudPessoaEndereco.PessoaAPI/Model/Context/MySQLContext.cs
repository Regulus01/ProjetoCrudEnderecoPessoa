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
            Guid idPessoa1 = Guid.NewGuid();
            Guid idPessoa2 = Guid.NewGuid();

            modelBuilder.Entity<Pessoa>().HasData(new Pessoa(
               idPessoa1,
               "jose",
               "jose@gmail.com"
               ));

            modelBuilder.Entity<Pessoa>().HasData(new Pessoa(
                idPessoa2,
                "rodney",
                "rodney@gmail.com"
                ));

            modelBuilder.Entity<Endereco>().HasData(new Endereco(
                Guid.NewGuid(),
                "49032490",
                "av.murilo dantas",
                "1155",
                "SE",
                "Farolandia",
                "Farol",
                idPessoa1));

            modelBuilder.Entity<Endereco>().HasData(new Endereco(
                Guid.NewGuid(),
                "5512460",
                "av.dantas",
                "1157",
                "SE",
                "Barra",
                "Coqueiros",
                idPessoa2));
           
        }
    }

}


