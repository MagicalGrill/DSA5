using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table(nameof(Anwendungsgebiet))]
public sealed class Anwendungsgebiet : NamedEntity
{
    [ForeignKey(nameof(Talent))] public Guid TalentId { get; set; }
}