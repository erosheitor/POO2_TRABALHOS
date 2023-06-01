using Atacado.BD.EF.Database;
using Atacado.BD.EF.DataBase;

namespace AtacadoConsole;

public class EstadoTestes : BaseTestes
{
    public EstadoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Exibindo categorias");

        foreach (Estado item in this.context.Estados)
        {
            Console.WriteLine($"{item.CodigoEstado} - {item.Nome}");
        }
    }
}
