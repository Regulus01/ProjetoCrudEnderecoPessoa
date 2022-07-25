using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudPessoaEndereco.PessoaAPI.Migrations
{
    public partial class seedPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "EnderecoId", "Bairro", "Cep", "Cidade", "Estado", "Logradouro", "Numero" },
                values: new object[] { new Guid("04a4da82-44b4-46b1-a007-4494c9f26b36"), "Farolandia", "49032490", "Aracaju", "SE", "av.murilo dantas", "1155" });

            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "EnderecoId", "Bairro", "Cep", "Cidade", "Estado", "Logradouro", "Numero" },
                values: new object[] { new Guid("707dfb0d-9b3e-4868-b046-963293356108"), "Conqueiros", "5512460", "Barra", "SE", "av.dantas", "1157" });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "id", "Email", "EnderecoId", "Nome" },
                values: new object[] { new Guid("3e672a03-8e9f-41ac-bf52-cad17dbd66d8"), "rodney@gmail.com", new Guid("707dfb0d-9b3e-4868-b046-963293356108"), "rodney" });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "id", "Email", "EnderecoId", "Nome" },
                values: new object[] { new Guid("78673a06-2f37-451d-9524-bdaae5f6e685"), "jose@gmail.com", new Guid("04a4da82-44b4-46b1-a007-4494c9f26b36"), "jose" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pessoa",
                keyColumn: "id",
                keyValue: new Guid("3e672a03-8e9f-41ac-bf52-cad17dbd66d8"));

            migrationBuilder.DeleteData(
                table: "Pessoa",
                keyColumn: "id",
                keyValue: new Guid("78673a06-2f37-451d-9524-bdaae5f6e685"));

            migrationBuilder.DeleteData(
                table: "Endereco",
                keyColumn: "EnderecoId",
                keyValue: new Guid("04a4da82-44b4-46b1-a007-4494c9f26b36"));

            migrationBuilder.DeleteData(
                table: "Endereco",
                keyColumn: "EnderecoId",
                keyValue: new Guid("707dfb0d-9b3e-4868-b046-963293356108"));
        }
    }
}
