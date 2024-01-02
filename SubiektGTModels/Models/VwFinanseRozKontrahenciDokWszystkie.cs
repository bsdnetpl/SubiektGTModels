using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseRozKontrahenciDokWszystkie
{
    public int NzfId { get; set; }

    public DateTime? NzfTerminPlatnosci { get; set; }

    public int NzfTyp { get; set; }

    public int NzfStatus { get; set; }

    public string? NzfNumerPelny { get; set; }

    public int? NzfIdObiektu { get; set; }

    public int NzfTypObiektu { get; set; }

    public int? NzfIdAdresu { get; set; }

    public decimal NzfWartoscPierwotna { get; set; }

    public DateTime NzfData { get; set; }

    public int? Spoznienie { get; set; }

    public bool NzfNota { get; set; }

    public int? NzfProgram { get; set; }

    public int? NzfZrodlo { get; set; }

    public bool NzfPowiazanie { get; set; }

    public int NzfIdWystawil { get; set; }

    public int? NzfIdKategorii { get; set; }

    public decimal? Naleznosc { get; set; }

    public decimal? Zobowiazanie { get; set; }

    public decimal? NalWaluta { get; set; }

    public decimal? ZobWaluta { get; set; }

    public decimal? NalPierwotna { get; set; }

    public decimal? ZobPierwotna { get; set; }

    public decimal? NalPierwotnaWaluta { get; set; }

    public decimal? ZobPierwotnaWaluta { get; set; }

    public string NzfIdWaluty { get; set; } = null!;

    public int? NzfTypOdsetek { get; set; }

    public decimal? NzfStopaOdsetek { get; set; }

    public int? NzfIdDokumentAuto { get; set; }

    public int? DokPlatnikAdresHid { get; set; }

    public int? NzfPodtyp { get; set; }
}
