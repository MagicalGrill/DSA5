using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table(nameof(Nachteil))]
public class Nachteil : DescriptedEntity
{
    public int MaxStufe { get; set; }
    public int ApProStufe { get; set; }
    public int MaxAnzahl { get; set; }
    public bool IstSchlechteEigenschaft { get; set; }
    public bool IstPersoenlichkeitsschwaeche { get; set; }
}