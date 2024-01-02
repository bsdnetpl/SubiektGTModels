using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDokDoDekretacji
{
    public int? Ident { get; set; }

    public int? DokId { get; set; }

    public int? DokMagId { get; set; }

    public DateTime? DokDataWyst { get; set; }

    public int? TypDlugi { get; set; }

    public string? NazwaTypu { get; set; }

    public int? DokNr { get; set; }

    public string? DokNrPelny { get; set; }

    public string? DokNrPelnyOryg { get; set; }

    public string? KhSymbol { get; set; }

    public string? AdrhNazwa { get; set; }

    public string? AdrhAdres { get; set; }

    public string? AdrhMiejscowosc { get; set; }

    public decimal? DokKwWartosc { get; set; }

    public string? KatNazwa { get; set; }

    public int? DokStatusKsieg { get; set; }

    public int? NzfIdKasy { get; set; }

    public int? NzfIdRachunku { get; set; }

    public int? DokStatus { get; set; }

    public int? KatId { get; set; }

    public int? Si { get; set; }
}
