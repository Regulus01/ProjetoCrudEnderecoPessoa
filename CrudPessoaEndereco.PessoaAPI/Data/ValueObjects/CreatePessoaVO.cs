namespace CrudPessoaEndereco.PessoaAPI.Data.ValueObjects
{
    public class CreatePessoaVO
    {
        public string Nome { get; set; }
        public string? Email { get; set; }
        public virtual EnderecoVO? Endereco { get; set; }
    }
}
