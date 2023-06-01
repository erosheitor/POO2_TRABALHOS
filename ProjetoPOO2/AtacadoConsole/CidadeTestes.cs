using Atacado.BD.EF.Database;
using Atacado.BD.EF.DataBase;

namespace AtacadoConsole;

public class CidadeTestes : BaseTestes
{
    public CidadeTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Exibindo categorias");

        foreach (Cidade item in this.context.Cidades)
        {
            Console.WriteLine($"{item.CodigoCidade} - {item.CodigoIBGE7}");
        }
    }
}
