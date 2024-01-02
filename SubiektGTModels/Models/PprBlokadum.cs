using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PprBlokadum
{
    public int PprbId { get; set; }

    public int PprbIdPrac { get; set; }

    public DateTime PprbDataOd { get; set; }

    public DateTime PprbDataDo { get; set; }

    public int PprbStatus { get; set; }

    public virtual PrPracownik PprbIdPracNavigation { get; set; } = null!;
}
