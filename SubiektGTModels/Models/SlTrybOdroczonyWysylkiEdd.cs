using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlTrybOdroczonyWysylkiEdd
{
    public int SltowId { get; set; }

    public string SltowWartosc { get; set; } = null!;

    public bool SltowAktywna { get; set; }

    public virtual ICollection<EddParametr> EddParametrs { get; set; } = new List<EddParametr>();
}
