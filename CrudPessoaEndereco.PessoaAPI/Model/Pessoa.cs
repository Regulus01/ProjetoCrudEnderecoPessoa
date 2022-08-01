using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroPessoaEndereco.PessoaAPI.Model
{
    [Table("Pessoa")]
    public class Pessoa 
    {
        [Key]
        [Column("PessoaId")]
        [Required]
        public Guid PessoaId { get; private set; }

        [Column("Nome")]
        [Required]
        [StringLength(80)]
        public string Nome { get; private set; }

        [Column("Email")]
        [EmailAddress]
        public string? Email { get; private set; }

        [Column("Endereco")]
        public virtual Endereco? Endereco { get; private set; }

        public Pessoa()
        {
        }

        public Pessoa(Guid id, string nome, string? email)
        {
            PessoaId = id;
            Nome = nome;
            Email = email;
        }

        public void AdicionaEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

    }
}

