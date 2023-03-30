namespace AtacadoConsole;

using Atacado.BD.EF.Database;
using Atacado.BD.EF.DataBase;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        //Criando a string de conexão com o banco de dados SQL Server.
        //string connectionString = "Data Source=(local);Initial Catalog=Atacado2023;User=usrAtacado;Password=senha123;TrustServerCertificate=True;";
        //var options = new DbContextOptionsBuilder<AtacadoContext>().UseSqlServer(connectionString).Options;
        var contexto = new AtacadoContext();

        //Executando a pesquisa para obter todos os registros de Categoria.
        //Em seguida, abrindo os resultados e exibindo um por um.
        Console.WriteLine("Executando pesquisa...");
        foreach (Estado item in contexto.Estados.AsNoTracking().ToList())
        {
            Console.WriteLine($"{item.CodigoEstado} - {item.Nome}");
        }
        Console.WriteLine("Fim do programa");
        Console.ReadLine();
    }
}
