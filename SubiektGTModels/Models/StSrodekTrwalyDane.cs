using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class StSrodekTrwalyDane
{
    public int StdId { get; set; }

    public int StdIdSrodka { get; set; }

    public decimal? StdWartoscPocz { get; set; }

    public decimal? StdWartoscPoczBil { get; set; }

    public decimal? StdUmorzDotych { get; set; }

    public decimal? StdUmorzDotychBil { get; set; }

    public decimal? StdWartoscNetto { get; set; }

    public decimal? StdWartoscNettoBil { get; set; }

    public int? StdIdMpk { get; set; }

    public string? StdUzytkownik { get; set; }

    public int? StdMetoda { get; set; }

    public int? StdMetodaBil { get; set; }

    public decimal? StdStopa { get; set; }

    public decimal? StdStopaBil { get; set; }

    public decimal? StdWspolczynnikDegr { get; set; }

    public decimal? StdWspolczynnikDegrBil { get; set; }

    public virtual StMpk? StdIdMpkNavigation { get; set; }

    public virtual StSrodekTrwaly StdIdSrodkaNavigation { get; set; } = null!;
}
