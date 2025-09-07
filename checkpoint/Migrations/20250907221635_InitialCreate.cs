using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace checkpoint.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RM551605_FORNECEDOR",
                columns: table => new
                {
                    idFornecedor = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nrCEP = table.Column<string>(type: "NVARCHAR2(9)", maxLength: 9, nullable: false),
                    dsEndereco = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Estado = table.Column<string>(type: "NVARCHAR2(2)", maxLength: 2, nullable: false),
                    Cidade = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RM551605_FORNECEDOR", x => x.idFornecedor);
                });

            migrationBuilder.CreateTable(
                name: "RM551605_PEDIDO",
                columns: table => new
                {
                    idPedido = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    dataPedido = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    valorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RM551605_PEDIDO", x => x.idPedido);
                });

            migrationBuilder.CreateTable(
                name: "RM551605_PRODUTO",
                columns: table => new
                {
                    idProduto = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nmProduto = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false),
                    preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RM551605_PRODUTO", x => x.idProduto);
                });

            migrationBuilder.InsertData(
                table: "RM551605_FORNECEDOR",
                columns: new[] { "idFornecedor", "Cidade", "Estado", "dsEndereco", "nrCEP" },
                values: new object[,]
                {
                    { 1, "São Paulo", "SP", "Rua A, 100", "01000-000" },
                    { 2, "Campinas", "SP", "Rua B, 200", "02000-000" },
                    { 3, "Rio de Janeiro", "RJ", "Rua C, 300", "03000-000" },
                    { 4, "Niterói", "RJ", "Rua D, 400", "04000-000" },
                    { 5, "Belo Horizonte", "MG", "Rua E, 500", "05000-000" },
                    { 6, "Uberlândia", "MG", "Rua F, 600", "06000-000" },
                    { 7, "Salvador", "BA", "Rua G, 700", "07000-000" },
                    { 8, "Feira de Santana", "BA", "Rua H, 800", "08000-000" },
                    { 9, "Curitiba", "PR", "Rua I, 900", "09000-000" },
                    { 10, "Londrina", "PR", "Rua J, 1000", "10000-000" }
                });

            migrationBuilder.InsertData(
                table: "RM551605_PEDIDO",
                columns: new[] { "idPedido", "dataPedido", "valorTotal" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 28, 19, 16, 34, 242, DateTimeKind.Local).AddTicks(9374), 150.00m },
                    { 2, new DateTime(2025, 8, 29, 19, 16, 34, 245, DateTimeKind.Local).AddTicks(1277), 500.00m },
                    { 3, new DateTime(2025, 8, 30, 19, 16, 34, 245, DateTimeKind.Local).AddTicks(1300), 250.00m },
                    { 4, new DateTime(2025, 8, 31, 19, 16, 34, 245, DateTimeKind.Local).AddTicks(1302), 700.00m },
                    { 5, new DateTime(2025, 9, 1, 19, 16, 34, 245, DateTimeKind.Local).AddTicks(1303), 1300.00m },
                    { 6, new DateTime(2025, 9, 2, 19, 16, 34, 245, DateTimeKind.Local).AddTicks(1305), 200.00m },
                    { 7, new DateTime(2025, 9, 3, 19, 16, 34, 245, DateTimeKind.Local).AddTicks(1306), 320.00m },
                    { 8, new DateTime(2025, 9, 4, 19, 16, 34, 245, DateTimeKind.Local).AddTicks(1307), 80.00m },
                    { 9, new DateTime(2025, 9, 5, 19, 16, 34, 245, DateTimeKind.Local).AddTicks(1308), 400.00m },
                    { 10, new DateTime(2025, 9, 6, 19, 16, 34, 245, DateTimeKind.Local).AddTicks(1309), 1000.00m }
                });

            migrationBuilder.InsertData(
                table: "RM551605_PRODUTO",
                columns: new[] { "idProduto", "nmProduto", "preco" },
                values: new object[,]
                {
                    { 1, "Mouse", 50.00m },
                    { 2, "Teclado", 120.00m },
                    { 3, "Monitor", 800.00m },
                    { 4, "Notebook", 3500.00m },
                    { 5, "Impressora", 700.00m },
                    { 6, "HD Externo", 400.00m },
                    { 7, "SSD", 500.00m },
                    { 8, "Cabo HDMI", 35.00m },
                    { 9, "Fonte ATX", 250.00m },
                    { 10, "Headset", 150.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RM551605_FORNECEDOR");

            migrationBuilder.DropTable(
                name: "RM551605_PEDIDO");

            migrationBuilder.DropTable(
                name: "RM551605_PRODUTO");
        }
    }
}
