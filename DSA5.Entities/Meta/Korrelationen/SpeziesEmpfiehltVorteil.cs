﻿using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(SpeziesEmpfiehltVorteil))]
public sealed class SpeziesEmpfiehltVorteil : BaseEntity
{
    [ForeignKey(nameof(Spezies))]
    public Guid SpeziesId { get; set; }
    [ForeignKey(nameof(Welt.Vorteil))]
    public Guid VorteilId { get; set; }
    public Empfehlungsstufe Empfehlungsstufe { get; set; }
    
    public Vorteil Vorteil { get; set; } = null!;
}