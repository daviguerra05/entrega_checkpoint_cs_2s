using Microsoft.EntityFrameworkCore;
using ProjetoEF.Models;

namespace ProjetoEF.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<RM551605_Fornecedor> Fornecedores { get; set; }
        public DbSet<RM551605_Produto> Produtos { get; set; }
        public DbSet<RM551605_Pedido> Pedidos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Exemplo de string de conexão Oracle
            optionsBuilder.UseOracle("User Id=RM551605;Password=050104;Data Source=oracle.fiap.com.br:1521/ORCL");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RM551605_Fornecedor>().HasData(
                new RM551605_Fornecedor { idFornecedor = 1, nrCEP = "01000-000", dsEndereco = "Rua A, 100", Estado = "SP", Cidade = "São Paulo" },
                new RM551605_Fornecedor { idFornecedor = 2, nrCEP = "02000-000", dsEndereco = "Rua B, 200", Estado = "SP", Cidade = "Campinas" },
                new RM551605_Fornecedor { idFornecedor = 3, nrCEP = "03000-000", dsEndereco = "Rua C, 300", Estado = "RJ", Cidade = "Rio de Janeiro" },
                new RM551605_Fornecedor { idFornecedor = 4, nrCEP = "04000-000", dsEndereco = "Rua D, 400", Estado = "RJ", Cidade = "Niterói" },
                new RM551605_Fornecedor { idFornecedor = 5, nrCEP = "05000-000", dsEndereco = "Rua E, 500", Estado = "MG", Cidade = "Belo Horizonte" },
                new RM551605_Fornecedor { idFornecedor = 6, nrCEP = "06000-000", dsEndereco = "Rua F, 600", Estado = "MG", Cidade = "Uberlândia" },
                new RM551605_Fornecedor { idFornecedor = 7, nrCEP = "07000-000", dsEndereco = "Rua G, 700", Estado = "BA", Cidade = "Salvador" },
                new RM551605_Fornecedor { idFornecedor = 8, nrCEP = "08000-000", dsEndereco = "Rua H, 800", Estado = "BA", Cidade = "Feira de Santana" },
                new RM551605_Fornecedor { idFornecedor = 9, nrCEP = "09000-000", dsEndereco = "Rua I, 900", Estado = "PR", Cidade = "Curitiba" },
                new RM551605_Fornecedor { idFornecedor = 10, nrCEP = "10000-000", dsEndereco = "Rua J, 1000", Estado = "PR", Cidade = "Londrina" }
            );

            modelBuilder.Entity<RM551605_Produto>().HasData(
                new RM551605_Produto { idProduto = 1, nmProduto = "Mouse", preco = 50.00m },
                new RM551605_Produto { idProduto = 2, nmProduto = "Teclado", preco = 120.00m },
                new RM551605_Produto { idProduto = 3, nmProduto = "Monitor", preco = 800.00m },
                new RM551605_Produto { idProduto = 4, nmProduto = "Notebook", preco = 3500.00m },
                new RM551605_Produto { idProduto = 5, nmProduto = "Impressora", preco = 700.00m },
                new RM551605_Produto { idProduto = 6, nmProduto = "HD Externo", preco = 400.00m },
                new RM551605_Produto { idProduto = 7, nmProduto = "SSD", preco = 500.00m },
                new RM551605_Produto { idProduto = 8, nmProduto = "Cabo HDMI", preco = 35.00m },
                new RM551605_Produto { idProduto = 9, nmProduto = "Fonte ATX", preco = 250.00m },
                new RM551605_Produto { idProduto = 10, nmProduto = "Headset", preco = 150.00m }
            );

            modelBuilder.Entity<RM551605_Pedido>().HasData(
                new RM551605_Pedido { idPedido = 1, dataPedido = DateTime.Now.AddDays(-10), valorTotal = 150.00m },
                new RM551605_Pedido { idPedido = 2, dataPedido = DateTime.Now.AddDays(-9), valorTotal = 500.00m },
                new RM551605_Pedido { idPedido = 3, dataPedido = DateTime.Now.AddDays(-8), valorTotal = 250.00m },
                new RM551605_Pedido { idPedido = 4, dataPedido = DateTime.Now.AddDays(-7), valorTotal = 700.00m },
                new RM551605_Pedido { idPedido = 5, dataPedido = DateTime.Now.AddDays(-6), valorTotal = 1300.00m },
                new RM551605_Pedido { idPedido = 6, dataPedido = DateTime.Now.AddDays(-5), valorTotal = 200.00m },
                new RM551605_Pedido { idPedido = 7, dataPedido = DateTime.Now.AddDays(-4), valorTotal = 320.00m },
                new RM551605_Pedido { idPedido = 8, dataPedido = DateTime.Now.AddDays(-3), valorTotal = 80.00m },
                new RM551605_Pedido { idPedido = 9, dataPedido = DateTime.Now.AddDays(-2), valorTotal = 400.00m },
                new RM551605_Pedido { idPedido = 10, dataPedido = DateTime.Now.AddDays(-1), valorTotal = 1000.00m }
            );
        }
    }
}
