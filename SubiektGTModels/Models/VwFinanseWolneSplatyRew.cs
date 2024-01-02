using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseWolneSplatyRew
{
    public int NzfId { get; set; }

    public DateTime NzfData { get; set; }

    public int NzfTyp { get; set; }

    public string? NzfTytulem { get; set; }

    public decimal NzfWartoscPierwotna { get; set; }

    public decimal NzfWartoscPierwotnaWaluta { get; set; }

    public decimal NzfWartosc { get; set; }

    public decimal NzfWartoscWaluta { get; set; }

    public string NzfIdWaluty { get; set; } = null!;

    public decimal NzfKurs { get; set; }

    public int NzfRodzajKursu { get; set; }

    public string NzfNumerPelny { get; set; } = null!;

    public int? NzfTypOdsetek { get; set; }

    public decimal? NzfStopaOdsetek { get; set; }

    public DateTime? NzfDataOstatniejSplaty { get; set; }

    public int? NzfIdDokumentAuto { get; set; }

    public int? NzfIdAdresu { get; set; }

    public int? NzfIdHistoriiAdresu { get; set; }

    public int? NzfIdObiektu { get; set; }

    public int NzfTypObiektu { get; set; }

    public int NzfStatus { get; set; }

    public string? NzfPrb { get; set; }

    public int? NzfIdKategorii { get; set; }

    public int NzfIdWystawil { get; set; }

    public bool NzfPrzeniesiony { get; set; }

    public bool NzfNota { get; set; }

    public int? NzfPodtyp { get; set; }

    public int? NzfProgram { get; set; }

    public int? NzfZrodlo { get; set; }

    public bool NzfPowiazanie { get; set; }

    public decimal? SpNal { get; set; }

    public decimal? SpZob { get; set; }

    public decimal? SpNalWaluta { get; set; }

    public decimal? SpZobWaluta { get; set; }

    public decimal? SpNalPierwotna { get; set; }

    public decimal? SpZobPierwotna { get; set; }

    public decimal? SpNalPierwotnaWaluta { get; set; }

    public decimal? SpZobPierwotnaWaluta { get; set; }

    public int? DokTyp { get; set; }

    public int? Rozliczenie { get; set; }

    public int? NzfFlaga { get; set; }

    public int? NzfFlagaZmianaPersonelId { get; set; }

    public DateTime? NzfFlagaZmianaCzas { get; set; }

    public int TypSplaty { get; set; }

    public string? NzfWystawil { get; set; }

    public DateTime? SsDataZamkniecia { get; set; }

    public DateTime? SsDataBlokadyRach { get; set; }
}
