using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Meta;

[Table(nameof(Erfahrungsgrad))]
public sealed class Erfahrungsgrad : DescriptedEntity
{
    public int ApGuthaben { get; set; }
    public int MaxEigenschaftWert { get; set; }
    public int MaxFertigkeitWert { get; set; }
    public int MaxKampftechnikWert { get; set; }
    public int MaxEigenschaftsPunkte { get; set; }
    public int MaxZauberLiturgien { get; set; }
    public int MaxFremdzauber { get; set; }
}