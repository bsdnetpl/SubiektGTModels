using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzSyncHistoriaWiarygodnoscPlatnicza
{
    public int? NzshwpKontrahentId { get; set; }

    public DateTime? NzshwpData { get; set; }

    public string? NzshwpNumerPelny { get; set; }

    public DateTime? NzshwpTerminPlatnosci { get; set; }

    public DateTime? NzshwpDataOstatniejSplaty { get; set; }

    public decimal? NzshwpDniSpoznienia { get; set; }

    public decimal? NzshwpWartoscPierwotnaWaluta { get; set; }

    public decimal? NzshwpWartoscWaluta { get; set; }

    public string? NzshwpIdWaluty { get; set; }

    public decimal? NzshwpKurs { get; set; }

    public decimal? NzshwpWartoscPierwotna { get; set; }

    public decimal? NzshwpWartosc { get; set; }
}
