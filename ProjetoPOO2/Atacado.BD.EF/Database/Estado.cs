namespace Atacado.BD.EF.DataBase;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("Estado")]

public partial class Estado 
{
    [Key]

    public Int64 CodigoEstado { get; set; }

    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [Unicode(false)]
    public string UF {get; set; } = null!;

    public Int64 CodigoRegiao { get; set; }
}
