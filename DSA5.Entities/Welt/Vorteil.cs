using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table(nameof(Vorteil))]
public class Vorteil : DescriptedEntity
{
    public int MaxStufe { get; set; }
    public int ApProStufe { get; set; }
    public int MaxAnzahl { get; set; }
}