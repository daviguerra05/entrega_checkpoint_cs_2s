using ProjetoEF.Data;

class Program
{
    static void Main(string[] args)
    {
        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();
            Console.WriteLine("Banco de dados criado com sucesso!");
        }
    }
}
