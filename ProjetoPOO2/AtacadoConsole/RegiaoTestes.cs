using Atacado.BD.EF.Database;
using Atacado.BD.EF.DataBase;

namespace AtacadoConsole;

public class RegiaoTestes : BaseTestes
{
    public RegiaoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Exibindo categorias");

        foreach (Regiao item in this.context.Regioes)
        {
            Console.WriteLine($"{item.CodigoRegiao} - {item.Nome}");
        }
    }
}
