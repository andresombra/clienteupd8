using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClienteUpd8.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InicialCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "CPF", "Cidade", "DataNascimento", "Endereco", "Estado", "Nome", "Sexo" },
                values: new object[] { 1, "580.941.213-00", "Fortaleza", new DateTime(1975, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Nove, 40", "Ceara", "Andre Sombra", "M" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
