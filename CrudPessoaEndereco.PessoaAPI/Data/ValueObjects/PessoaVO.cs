namespace CrudPessoaEndereco.PessoaAPI.Data.ValueObjects
{
    public class PessoaVO
    {    
        public Guid PessoaId { get; set; }
        public string Nome { get; set; }    
        public string? Email { get; set; }
        public virtual EnderecoVO? Endereco { get; set; }
    }
}
