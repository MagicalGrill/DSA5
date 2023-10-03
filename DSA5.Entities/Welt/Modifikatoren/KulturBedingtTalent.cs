using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Modifikatoren;

[Table("KulturBedingtTalent")]
public class KulturBedingtTalent : BaseEntity, ITalentModifikator
{
    [ForeignKey("Kultur")]
    public Guid KulturId { get; set; }
    [ForeignKey("Talent")]
    public Guid TalentId { get; set; }

    public Talent Talent { get; set; } = null!;
    public int Wert { get; set; }
}