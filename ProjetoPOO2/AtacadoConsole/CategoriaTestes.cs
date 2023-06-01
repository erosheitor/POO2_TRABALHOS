using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class CategoriaTestes : BaseTestes
{
    public CategoriaTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Exibindo categorias");

        foreach (Categoria item in this.context.Categorias)
        {
            Console.WriteLine($"{item.Codigo} - {item.Descricao}");
        }
    }
}
