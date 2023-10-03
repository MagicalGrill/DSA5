using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

public class Kulturgruppe : DescriptedEntity
{
    public virtual IEnumerable<Kultur> Kulturen { get; set; } = null!;
}