using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratSqlViewProwizja
{
    public int Ident { get; set; }

    public string? Nazwisko { get; set; }

    public string? Imie { get; set; }

    public string? Imie2 { get; set; }

    public DateTime Data { get; set; }

    public string Nazwa { get; set; } = null!;

    public string? TypStawki { get; set; }

    public decimal? OpisPrzelicznikaStawki { get; set; }

    public decimal Kwota { get; set; }

    public decimal Wartosc { get; set; }

    public string Rozliczony { get; set; } = null!;

    public string SposobRozliczenia { get; set; } = null!;

    public string? DokumentRozliczajacy { get; set; }

    public decimal? Suma { get; set; }

    public string PrOpis { get; set; } = null!;
}
