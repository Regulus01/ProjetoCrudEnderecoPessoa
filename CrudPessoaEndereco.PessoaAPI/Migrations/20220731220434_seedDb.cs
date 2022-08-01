using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudPessoaEndereco.PessoaAPI.Migrations
{
    public partial class seedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "PessoaId", "Email", "Nome" },
                values: new object[] { new Guid("26f753a5-6ed9-45b0-95c1-9113148e6e1d"), "rodney@gmail.com", "rodney" });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "PessoaId", "Email", "Nome" },
                values: new object[] { new Guid("e377f741-b75e-4fab-8a51-1af9c01a6a95"), "jose@gmail.com", "jose" });

            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "EnderecoId", "Bairro", "Cep", "Cidade", "Estado", "Logradouro", "Numero", "PessoaId" },
                values: new object[] { new Guid("0020a95c-9b37-4bbe-a017-6d658e3dd0d2"), "Farol", "49032490", "Farolandia", "SE", "av.murilo dantas", "1155", new Guid("e377f741-b75e-4fab-8a51-1af9c01a6a95") });

            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "EnderecoId", "Bairro", "Cep", "Cidade", "Estado", "Logradouro", "Numero", "PessoaId" },
                values: new object[] { new Guid("6be645b6-4bb6-4206-a0b8-ad211f25e2da"), "Coqueiros", "5512460", "Barra", "SE", "av.dantas", "1157", new Guid("26f753a5-6ed9-45b0-95c1-9113148e6e1d") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Endereco",
                keyColumn: "EnderecoId",
                keyValue: new Guid("0020a95c-9b37-4bbe-a017-6d658e3dd0d2"));

            migrationBuilder.DeleteData(
                table: "Endereco",
                keyColumn: "EnderecoId",
                keyValue: new Guid("6be645b6-4bb6-4206-a0b8-ad211f25e2da"));

            migrationBuilder.DeleteData(
                table: "Pessoa",
                keyColumn: "PessoaId",
                keyValue: new Guid("26f753a5-6ed9-45b0-95c1-9113148e6e1d"));

            migrationBuilder.DeleteData(
                table: "Pessoa",
                keyColumn: "PessoaId",
                keyValue: new Guid("e377f741-b75e-4fab-8a51-1af9c01a6a95"));
        }
    }
}
