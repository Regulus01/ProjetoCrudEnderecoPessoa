﻿using CrudPessoaEndereco.PessoaAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroPessoaEndereco.PessoaAPI.Model
{
    [Table("Pessoa")]
    public class Pessoa : BaseEntity
    {
        private object value;

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

        public Pessoa(string nome, string? email, Endereco? endereco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Endereco = endereco;
        }

    }
}

