using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwStanOddzial
{
    public int TsoTwId { get; set; }

    public int TsoMagId { get; set; }

    public int TsoOddzialId { get; set; }

    public decimal TsoStan { get; set; }

    public DateTime TsoData { get; set; }
}
