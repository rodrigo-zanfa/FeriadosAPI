using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FeriadosAPI.Migrations
{
    public partial class _01CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APIFeriadoEstadual",
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
                    table.PrimaryKey("PK_APIFeriadoEstadual", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "APIFeriadoMunicipal",
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
                    table.PrimaryKey("PK_APIFeriadoMunicipal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "APIFeriadoNacional",
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
                    table.PrimaryKey("PK_APIFeriadoNacional", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "APIFeriadoEstadual",
                columns: new[] { "Id", "Data", "FixoMovel", "Nome", "Uf" },
                values: new object[,]
                {
                    { 1, new DateTime(1900, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Revolução Constitucionalista de 1932", "SP" },
                    { 2, new DateTime(1900, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Dia de São Jorge", "RJ" },
                    { 3, new DateTime(1900, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Dia da Consciência Negra", "RJ" },
                    { 4, new DateTime(1900, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Data Magna de Minas Gerais", "MG" }
                });

            migrationBuilder.InsertData(
                table: "APIFeriadoMunicipal",
                columns: new[] { "Id", "Cidade", "Data", "FixoMovel", "Nome", "Uf" },
                values: new object[,]
                {
                    { 1, "Guarulhos", new DateTime(1900, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Aniversário de Guarulhos", "SP" },
                    { 2, "São Paulo", new DateTime(1900, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Aniversário de São Paulo", "SP" }
                });

            migrationBuilder.InsertData(
                table: "APIFeriadoNacional",
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
                name: "APIFeriadoEstadual");

            migrationBuilder.DropTable(
                name: "APIFeriadoMunicipal");

            migrationBuilder.DropTable(
                name: "APIFeriadoNacional");
        }
    }
}
