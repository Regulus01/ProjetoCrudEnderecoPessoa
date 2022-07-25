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
            Guid idEndereco = Guid.NewGuid();
            Guid idEndereco2 = Guid.NewGuid();
          
            modelBuilder.Entity<Endereco>().HasData(new Endereco(
                idEndereco, 
                "49032490", 
                "av.murilo dantas", 
                "1155", 
                "SE", 
                "Aracaju", 
                "Farolandia"));

            modelBuilder.Entity<Pessoa>().HasData(new Pessoa(
                "jose",
                "jose@gmail.com",
                idEndereco
                ));

            modelBuilder.Entity<Endereco>().HasData(new Endereco(
               idEndereco2,
               "5512460",
               "av.dantas",
               "1157",
               "SE",
               "Barra",
               "Conqueiros"));

            modelBuilder.Entity<Pessoa>().HasData(new Pessoa(
                "rodney",
                "rodney@gmail.com",
                idEndereco2
                ));
        }
    }

}


