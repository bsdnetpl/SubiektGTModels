using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseDokumenty
{
    public int NzfId { get; set; }

    public DateTime NzfData { get; set; }

    public DateTime? NzfTerminPlatnosci { get; set; }

    public int NzfTyp { get; set; }

    public decimal NzfWartoscPierwotna { get; set; }

    public decimal NzfWartoscPierwotnaWaluta { get; set; }

    public decimal NzfWartosc { get; set; }

    public decimal NzfWartoscWaluta { get; set; }

    public decimal NzfSplata { get; set; }

    public decimal NzfSplataWaluta { get; set; }

    public string NzfIdWaluty { get; set; } = null!;

    public decimal NzfKurs { get; set; }

    public string? NzfTytulem { get; set; }

    public DateTime? NzfDataOstatniejSplaty { get; set; }

    public int? NzfIdDokumentAuto { get; set; }

    public int? NzfIdAdresu { get; set; }

    public int? NzfIdHistoriiAdresu { get; set; }

    public int? NzfIdObiektu { get; set; }

    public int NzfTypObiektu { get; set; }

    public int NzfStatus { get; set; }

    public int? NzfIdKategorii { get; set; }

    public int NzfIdWystawil { get; set; }

    public bool NzfNota { get; set; }

    public int? NzfPodtyp { get; set; }

    public int? NzfZrodlo { get; set; }

    public int? NzfProgram { get; set; }

    public int? NzfIdRozrachunku { get; set; }

    public bool NzfPowiazanie { get; set; }

    public bool NzfKorekta { get; set; }

    public string? NzfTransakcja { get; set; }

    public string? NzfNumerPelny { get; set; }

    public int? DniSpoznienia { get; set; }

    public decimal WartoscPierwotna { get; set; }

    public decimal WartoscPierwotnaWaluta { get; set; }

    public decimal? Wartosc { get; set; }

    public decimal? WartoscWaluta { get; set; }

    public int? Rozliczenie { get; set; }

    public int? DokPlatnikAdresHid { get; set; }

    public int? DokTyp { get; set; }

    public bool NzfZaliczka { get; set; }
}
