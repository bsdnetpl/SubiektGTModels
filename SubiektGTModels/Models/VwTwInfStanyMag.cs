using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwTwInfStanyMag
{
    public int StTowId { get; set; }

    public string MagNazwa { get; set; } = null!;

    public decimal StStan { get; set; }

    public decimal StStanRez { get; set; }

    public decimal? SsStanDost { get; set; }

    public int StMagId { get; set; }
}
