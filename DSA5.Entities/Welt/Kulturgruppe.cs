using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table(nameof(Kulturgruppe))]
public class Kulturgruppe : DescriptedEntity
{
    public virtual IEnumerable<Kultur> Kulturen { get; set; } = null!;
}