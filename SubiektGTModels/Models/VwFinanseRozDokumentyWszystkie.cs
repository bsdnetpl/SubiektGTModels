using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseRozDokumentyWszystkie
{
    public int NzfId { get; set; }

    public DateTime NzfData { get; set; }

    public DateTime? NzfTerminPlatnosci { get; set; }

    public int NzfTyp { get; set; }

    public decimal NzfWartoscPierwotna { get; set; }

    public decimal NzfWartoscPierwotnaWaluta { get; set; }

    public decimal NzfWartosc { get; set; }

    public decimal NzfWartoscWaluta { get; set; }

    public string NzfIdWaluty { get; set; } = null!;

    public decimal NzfKurs { get; set; }

    public int NzfRodzajKursu { get; set; }

    public string? NzfNumerPelny { get; set; }

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

    public int? DniSpoznienia { get; set; }

    public int? NzfProgram { get; set; }

    public int? NzfZrodlo { get; set; }

    public bool NzfPowiazanie { get; set; }

    public decimal? Naleznosc { get; set; }

    public decimal? Zobowiazanie { get; set; }

    public decimal? NalWaluta { get; set; }

    public decimal? ZobWaluta { get; set; }

    public decimal? NalPierwotna { get; set; }

    public decimal? ZobPierwotna { get; set; }

    public decimal? NalPierwotnaWaluta { get; set; }

    public decimal? ZobPierwotnaWaluta { get; set; }

    public DateTime? NzfDataKursu { get; set; }

    public int? NzfIdBanku { get; set; }

    public int NzfLiczbaJednostek { get; set; }

    public bool NzfMetodaKasowa { get; set; }

    public bool NzfKorekta { get; set; }

    public int NzfPodtypPp { get; set; }

    public decimal NzfVatpierwotnyWaluta { get; set; }

    public decimal NzfVatpierwotny { get; set; }

    public decimal NzfVatpozostaloWaluta { get; set; }

    public decimal NzfVatpozostalo { get; set; }

    public string? NzfNrFaktury { get; set; }

    public decimal? NzfKwotaRachunkuVat { get; set; }

    public bool NzfMechanizmPodzielonejPlatnosci { get; set; }
}
