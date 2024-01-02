using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlPojTrasa
{
    public int SptrId { get; set; }

    public string SptrTrasa { get; set; } = null!;

    public decimal SptrKm { get; set; }

    public virtual ICollection<PojParametr> PojParametrs { get; set; } = new List<PojParametr>();

    public virtual ICollection<SlPojCel> SlPojCels { get; set; } = new List<SlPojCel>();
}
