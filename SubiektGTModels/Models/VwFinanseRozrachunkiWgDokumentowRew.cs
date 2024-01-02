using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseRozrachunkiWgDokumentowRew
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

    public string? NzfTytulem { get; set; }

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

    public decimal? NaleznoscSplaty { get; set; }

    public decimal? ZobowiazaniaSplaty { get; set; }

    public decimal? NaleznoscSplatyWaluta { get; set; }

    public decimal? ZobowiazaniaSplatyWaluta { get; set; }

    public decimal? NaleznoscSplatyPierwotne { get; set; }

    public decimal? ZobowiazaniaSplatyPierwotne { get; set; }

    public decimal? NaleznoscSplatyWalutaPierwotne { get; set; }

    public decimal? ZobowiazaniaSplatyWalutaPierwotne { get; set; }

    public int? DokPlatnikAdresHid { get; set; }

    public decimal? SpNal { get; set; }

    public decimal? SpZob { get; set; }

    public decimal? SpNalWaluta { get; set; }

    public decimal? SpZobWaluta { get; set; }

    public decimal? SpNalPierwotna { get; set; }

    public decimal? SpZobPierwotna { get; set; }

    public decimal? SpNalPierwotnaWaluta { get; set; }

    public decimal? SpZobPierwotnaWaluta { get; set; }

    public int NzfKorekta { get; set; }

    public int? DokTyp { get; set; }

    public int? Rozliczenie { get; set; }

    public int? DokMagId { get; set; }

    public decimal? WartoscRd { get; set; }

    public decimal? WartoscRu { get; set; }

    public string? NzfWystawil { get; set; }

    public int? NzfFlaga { get; set; }

    public int? NzfFlagaZmianaPersonelId { get; set; }

    public DateTime? NzfFlagaZmianaCzas { get; set; }

    public bool NzfMetodaKasowa { get; set; }

    public DateTime? SsDataZamkniecia { get; set; }

    public DateTime? SsDataBlokadyRach { get; set; }

    public int? NzfTermPlatStatus { get; set; }

    public string? NzfTermPlatTransId { get; set; }

    public decimal? PotVatDoZablokowania { get; set; }

    public decimal? PotVatDoOdblokowania { get; set; }

    public decimal? ZablokowanoVat { get; set; }

    public decimal? OdblokowanoVat { get; set; }

    public int? NzfImport { get; set; }

    public bool NzfMechanizmPodzielonejPlatnosci { get; set; }
}
