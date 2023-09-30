using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

public sealed class Steigerungsfaktor : BaseEntity
{
    public string Name { get; set; } = null!;
    public int ApKostenMultiplikator { get; set; }
}