using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table("Eigenschaft")]
public class Eigenschaft : DescriptedEntity
{
    public string Kuerzel { get; set; } = null!;
}