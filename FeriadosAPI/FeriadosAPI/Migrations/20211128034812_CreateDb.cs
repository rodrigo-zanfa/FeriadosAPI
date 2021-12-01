using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FeriadosAPI.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "API_FeriadoEstadual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uf = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    FixoMovel = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_API_FeriadoEstadual", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "API_FeriadoMunicipal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uf = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    FixoMovel = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_API_FeriadoMunicipal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "API_FeriadoNacional",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    FixoMovel = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_API_FeriadoNacional", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "API_FeriadoEstadual",
                columns: new[] { "Id", "Data", "FixoMovel", "Nome", "Uf" },
                values: new object[,]
                {
                    { 1, new DateTime(1900, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Revolução Constitucionalista de 1932", "SP" },
                    { 2, new DateTime(1900, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Dia de São Jorge", "RJ" },
                    { 3, new DateTime(1900, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Dia da Consciência Negra", "RJ" },
                    { 4, new DateTime(1900, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Data Magna de Minas Gerais", "MG" }
                });

            migrationBuilder.InsertData(
                table: "API_FeriadoMunicipal",
                columns: new[] { "Id", "Cidade", "Data", "FixoMovel", "Nome", "Uf" },
                values: new object[,]
                {
                    { 1, "Guarulhos", new DateTime(1900, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Aniversário de Guarulhos", "SP" },
                    { 2, "São Paulo", new DateTime(1900, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Aniversário de São Paulo", "SP" }
                });

            migrationBuilder.InsertData(
                table: "API_FeriadoNacional",
                columns: new[] { "Id", "Data", "FixoMovel", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Confraternização Universal" },
                    { 2, new DateTime(1900, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Tiradentes" },
                    { 3, new DateTime(1900, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Dia do Trabalhador" },
                    { 4, new DateTime(1900, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Independência" },
                    { 5, new DateTime(1900, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Nossa Senhora Aparecida" },
                    { 6, new DateTime(1900, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Finados" },
                    { 7, new DateTime(1900, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Proclamação da República" },
                    { 8, new DateTime(1900, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Natal" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "API_FeriadoEstadual");

            migrationBuilder.DropTable(
                name: "API_FeriadoMunicipal");

            migrationBuilder.DropTable(
                name: "API_FeriadoNacional");
        }
    }
}
