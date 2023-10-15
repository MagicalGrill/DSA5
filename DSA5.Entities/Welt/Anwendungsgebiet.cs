using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table(nameof(Anwendungsgebiet))]
public class Anwendungsgebiet : DescriptedEntity
{
    [ForeignKey(nameof(Talent))]
    public Guid TalentId { get; set; }
}