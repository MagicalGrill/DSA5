using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Meta.Korrelationen;

namespace DSA5.Entities.Welt;

[Table(nameof(Liturgie))]
public class Liturgie : Talent
{
    public virtual IEnumerable<LiturgieVerbreitung> Verbreitung { get; set; } = null!;
}