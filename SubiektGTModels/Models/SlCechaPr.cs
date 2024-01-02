using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlCechaPr
{
    public int CprId { get; set; }

    public string CprNazwa { get; set; } = null!;

    public virtual ICollection<PrCechaPr> PrCechaPrs { get; set; } = new List<PrCechaPr>();
}
