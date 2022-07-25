namespace CrudPessoaEndereco.PessoaAPI.Data.ValueObjects
{
    public class PessoaVO
    {   
        public string Nome { get; set; }
        public string? Email { get; set; }
        public EnderecoVO? Endereco { get; set; }
    }
}
