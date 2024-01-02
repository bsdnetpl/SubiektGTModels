using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzSyncRozrachunkiKontrahentum
{
    public int KontrahentId { get; set; }

    public int? NzfTyp { get; set; }

    public bool? NzfKorekta { get; set; }

    public bool? NzfNota { get; set; }

    public int? Rozliczenie { get; set; }

    public DateTime? NzfData { get; set; }

    public string? NzfNumerPelny { get; set; }

    public string? NzfTytulem { get; set; }

    public DateTime? NzfTerminPlatnosci { get; set; }

    public DateTime? NzfDataOstatniejSplaty { get; set; }

    public int? DniSpoznienia { get; set; }

    public decimal WartoscPierwotnaWaluta { get; set; }

    public decimal? WartoscWaluta { get; set; }

    public string? NzfIdWaluty { get; set; }

    public decimal? NzfKurs { get; set; }

    public decimal? WartoscPierwotna { get; set; }

    public decimal? Wartosc { get; set; }

    public string? KatNazwa { get; set; }

    public string? Uzytkownik { get; set; }

    public int? NzfZrodlo { get; set; }

    public bool? NzfMechanizmPodzielonejPlatnosci { get; set; }
}
