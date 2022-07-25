using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudPessoaEndereco.PessoaAPI.Model.Base
{
    public class BaseEntity
    {
        [Key]
        [Column("id")]
        [Required]
        public Guid Id { get; protected set; }

    }
}
