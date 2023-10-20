﻿using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(SonderfertigkeitBrauchtVorteil))]
public sealed class SonderfertigkeitBrauchtVorteil : BaseEntity
{
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid SonderfertigkeitId { get; set; }
    [ForeignKey(nameof(Vorteil))]
    public Guid VorteilId { get; set; }
}