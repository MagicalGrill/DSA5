using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Modifikatoren;

[Table(nameof(SpeziesBedingtEigenschaften))]
public class SpeziesBedingtEigenschaften : BaseEntity
{
    [ForeignKey(nameof(Spezies))]
    public Guid SpeziesId { get; set; }

    public virtual SpeziesKannEigenschaftBedingen BedingteEigenschaftMoeglichkeiten { get; set; } = null!;
}