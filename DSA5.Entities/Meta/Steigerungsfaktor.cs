using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Meta;

[Table(nameof(Steigerungsfaktor))]
public sealed class Steigerungsfaktor : BaseEntity
{
    public string Name { get; set; } = null!;
    public int ApKostenMultiplikator { get; set; }
}