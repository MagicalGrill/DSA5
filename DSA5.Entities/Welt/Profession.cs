using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Meta.Korrelationen;

namespace DSA5.Entities.Welt;

[Table(nameof(Profession))]
public class Profession : DescriptedEntity
{
    public virtual IEnumerable<ProfessionEmpfiehltVorteil> EmpfohleneVorteile { get; set; } = null!;
    public virtual IEnumerable<ProfessionEmpfiehltNachteil> EmpfohleneNachteile { get; set; } = null!;
    public virtual IEnumerable<ProfessionEmpfiehltSonderfertigkeit> EmpfohleneSonderfertigkeiten { get; set; } = null!;
}