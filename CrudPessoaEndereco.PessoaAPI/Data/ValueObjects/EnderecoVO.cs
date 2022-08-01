namespace CrudPessoaEndereco.PessoaAPI.Data.ValueObjects
{
    public class EnderecoVO
    {      
        public Guid EnderecoId { get; set; }
        public string? Cep { get; set; }    
        public string? Logradouro { get; set; }  
        public string? Numero { get; set; }   
        public string? EstadoUf { get; set; }     
        public string? Cidade { get; set; }     
        public string? Bairro { get; set; }
        public Guid PessoaId { get; set; }

    }
}
