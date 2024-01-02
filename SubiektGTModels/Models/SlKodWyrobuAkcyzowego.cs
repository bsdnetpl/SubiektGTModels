using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKodWyrobuAkcyzowego
{
    public int SlkwaId { get; set; }

    public string SlkwaWartosc { get; set; } = null!;

    public bool SlkwaAktywna { get; set; }

    public string SlkwaWartoscXml { get; set; } = null!;

    public virtual ICollection<TwTowar> TwTowars { get; set; } = new List<TwTowar>();
}
