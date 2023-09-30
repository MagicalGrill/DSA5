using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt.Modifikatoren;

namespace DSA5.Entities.Welt;

[Table("Kultur")]
public class Kultur : BaseEntity
{
    public string Name { get; set; } = null!;
    public int ApWert { get; set; }

    public virtual IEnumerable<KulturBedingtTalent> TalentModifikatoren { get; set; } = null!;
}