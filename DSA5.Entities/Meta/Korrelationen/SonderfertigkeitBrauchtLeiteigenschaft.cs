using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(SonderfertigkeitBrauchtLeiteigenschaft))]
public class SonderfertigkeitBrauchtLeiteigenschaft : BaseEntity
{
    public int MinWert { get; set; }
}