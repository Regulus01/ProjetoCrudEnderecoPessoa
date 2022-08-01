using AutoMapper;
using CadastroPessoaEndereco.PessoaAPI.Model;
using CrudPessoaEndereco.PessoaAPI.Data.ValueObjects;

namespace CrudPessoaEndereco.PessoaAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Pessoa, PessoaVO>().ReverseMap();
                config.CreateMap<Pessoa, CreatePessoaVO>().ReverseMap();
                config.CreateMap<Endereco, EnderecoVO>().ReverseMap();

            });
            return mappingConfig;
        }
    }
}
