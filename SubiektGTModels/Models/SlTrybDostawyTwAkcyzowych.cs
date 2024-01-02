using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlTrybDostawyTwAkcyzowych
{
    public int SltdtId { get; set; }

    public string SltdtWartosc { get; set; } = null!;

    public bool SltdtAktywna { get; set; }

    public virtual ICollection<EddParametr> EddParametrs { get; set; } = new List<EddParametr>();
}
