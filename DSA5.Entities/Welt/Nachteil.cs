﻿using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table("Nachteil")]
public class Nachteil : DescriptedEntity
{
    public int MaxStufe { get; set; }
    public int ApProStufe { get; set; }
    public bool IstSchlechteEigenschaft { get; set; }
    
    [ForeignKey("Eigenschaft")]
    public Guid? EigenschaftId { get; set; }
    public Eigenschaft? Eigenschaft { get; set; }
    
    [ForeignKey("Talent")]
    public Guid? TalentId { get; set; }
    public Talent? Talent { get; set; }
}