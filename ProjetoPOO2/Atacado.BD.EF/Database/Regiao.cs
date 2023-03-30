namespace Atacado.BD.EF.DataBase;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("Regiao")]
public partial class Regiao
{

    [Key]

    public Int64 CodigoRegiao {get; set; }

    public string Nome { get; set;}  = null!;

    public Regiao ()
    {

    }
}
