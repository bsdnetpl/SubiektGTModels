using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzSposobNaliczeniaOdsetek
{
    public DateTime? SrDataOd { get; set; }

    public DateTime? SrDataDo { get; set; }

    public decimal? SrWartoscRozrachunku { get; set; }

    public int? SrLiczbaDni { get; set; }

    public decimal? SrStopa { get; set; }

    public decimal? SrOdsetki { get; set; }

    public int? SrIdRozrachunku { get; set; }
}
