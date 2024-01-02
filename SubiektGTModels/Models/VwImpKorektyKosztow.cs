using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwImpKorektyKosztow
{
    public int Ident { get; set; }

    public int MagId { get; set; }

    public DateTime DokData { get; set; }

    public int? TypZlozony { get; set; }

    public string? NazwaTypu { get; set; }

    public int Nr { get; set; }

    public string NrPelny { get; set; } = null!;

    public string? NrOrygnalu { get; set; }

    public string? SymbolKh { get; set; }

    public string? NazwaKh { get; set; }

    public string? Adres { get; set; }

    public string? Miejsc { get; set; }

    public decimal? Kwota { get; set; }

    public string? NazwaKategorii { get; set; }

    public int StatusKsieg { get; set; }

    public int? IdKategorii { get; set; }

    public int DokTyp { get; set; }

    public int DokPodtyp { get; set; }
}
