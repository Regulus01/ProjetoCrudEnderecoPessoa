﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroPessoaEndereco.PessoaAPI.Model
{
    [Table("Endereco")]
    public class Endereco 
    {
        [Key]
        [Column("EnderecoId")]
        [Required]
        public Guid EnderecoId { get; private set; }

        [Column("Cep")]
        [StringLength(8)]
        public string? Cep { get; private set; }

        [Column("Logradouro")]
        [StringLength(80)]
        public string? Logradouro { get; private set; }

        [Column("Numero")]
        [StringLength(80)]
        public string? Numero { get; private set; }

        [Column("Estado")]
        [StringLength(2)]
        public string? EstadoUf { get; private set; }

        [Column("Cidade")]
        [StringLength(80)]
        public string? Cidade { get; private set; }

        [Column("Bairro")]
        [StringLength(80)]
        public string? Bairro { get; private set; }

        [ForeignKey("Pessoa")]
        public Guid PessoaId { get; private set; }
        public virtual Pessoa Pessoa { get; private set; }

        public Endereco()
        {
        }

        public Endereco(Guid enderecoId, string? cep, string? logradouro, string? numero, string? estado,
            string? cidade, string? bairro, Guid pessoaId)
        {
            EnderecoId = enderecoId;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            EstadoUf = estado;
            Cidade = cidade;
            Bairro = bairro;
            PessoaId = pessoaId;
        }
    }
}
