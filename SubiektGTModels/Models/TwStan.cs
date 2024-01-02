using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwStan
{
    public int StTowId { get; set; }

    public int StMagId { get; set; }

    public decimal StStan { get; set; }

    public decimal StStanMin { get; set; }

    public decimal StStanRez { get; set; }

    public decimal StStanMax { get; set; }

    public virtual SlMagazyn StMag { get; set; } = null!;

    public virtual TwTowar StTow { get; set; } = null!;
}
