using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwPolaWlasneFinanse
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

    public int NzfRodzajKursu { get; set; }

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

    public string? NzfOdebral { get; set; }

    public string? NzfWystawil { get; set; }

    public bool NzfPrzeniesiony { get; set; }

    public bool NzfNota { get; set; }

    public int? NzfPodtyp { get; set; }

    public int? NzfZrodlo { get; set; }

    public int? NzfProgram { get; set; }

    public int? NzfIdRozrachunku { get; set; }

    public bool NzfPowiazanie { get; set; }

    public bool NzfKorekta { get; set; }

    public string? NzfTransakcja { get; set; }

    public int? NzfIdKasy { get; set; }

    public int? NzfNumer { get; set; }

    public string? NzfNumerPelny { get; set; }

    public int? NzfImport { get; set; }

    public string? NzfOpis { get; set; }

    public bool NzfGenerujTytulem { get; set; }

    public bool NzfZaliczka { get; set; }

    public bool NzfDlaNieznany { get; set; }

    public int? NzfIdRachunku { get; set; }

    public int? NzfIdRachunkuHist { get; set; }

    public string? NzfNumerWyciagu { get; set; }

    public DateTime? NzfDataUzgodnienia { get; set; }

    public bool NzfWyslanaHb { get; set; }

    public bool NzfWydrukowana { get; set; }

    public bool NzfObslugaRachunku { get; set; }

    public bool NzfGotowkowa { get; set; }

    public int? NzfIdRachObiekt { get; set; }

    public int? NzfIdRachObiektHist { get; set; }

    public string NzfTypPrzelewu { get; set; } = null!;

    public string? NzfZuspodIdentyfikator { get; set; }

    public string? NzfZuspodTypIdentyfikatora { get; set; }

    public string? NzfZustypWplaty { get; set; }

    public string? NzfZusdeklaracja { get; set; }

    public string? NzfZusnrDeklaracji { get; set; }

    public string? NzfPodSymbol { get; set; }

    public string? NzfPodIdentyfikacjaZobowiazania { get; set; }

    public string? NzfPodOkres { get; set; }

    public bool NzfTransfer { get; set; }

    public string? NzfZusnrDecyzji { get; set; }

    public int? NzfIdRozliczenia { get; set; }

    public int? NzfFlaga { get; set; }

    public int? NzfFlagaZmianaPersonelId { get; set; }

    public DateTime? NzfFlagaZmianaCzas { get; set; }

    public DateTime? NzfDataKursu { get; set; }

    public int? NzfIdBanku { get; set; }

    public int NzfLiczbaJednostek { get; set; }

    public int? NzfRodzajSplaty { get; set; }

    public int? NzfIdRachunkuWirtualnego { get; set; }

    public int? NzfTypKorekty { get; set; }

    public bool NzfMetodaKasowa { get; set; }

    public int NzfIdTransakcjiVat { get; set; }

    public bool NzfIzbaCelna { get; set; }

    public int? NzfTermPlatStatus { get; set; }

    public string? NzfTermPlatTransId { get; set; }

    public int NzfPodtypPp { get; set; }

    public decimal NzfVatpierwotnyWaluta { get; set; }

    public decimal NzfVatpierwotny { get; set; }

    public decimal NzfVatpozostaloWaluta { get; set; }

    public decimal NzfVatpozostalo { get; set; }

    public string? NzfNrFaktury { get; set; }

    public decimal? NzfKwotaRachunkuVat { get; set; }

    public bool NzfMechanizmPodzielonejPlatnosci { get; set; }

    public int? NzfIdSesjiKasowej { get; set; }

    public int? PwdId { get; set; }

    public int? PwdTypObiektu { get; set; }

    public int? PwdIdObiektu { get; set; }

    public int? PwdIdPozycji { get; set; }

    public DateTime? PwdData01 { get; set; }

    public DateTime? PwdData02 { get; set; }

    public DateTime? PwdData03 { get; set; }

    public DateTime? PwdData04 { get; set; }

    public DateTime? PwdData05 { get; set; }

    public DateTime? PwdData06 { get; set; }

    public DateTime? PwdData07 { get; set; }

    public DateTime? PwdData08 { get; set; }

    public DateTime? PwdData09 { get; set; }

    public DateTime? PwdData10 { get; set; }

    public int? PwdLiczba01 { get; set; }

    public int? PwdLiczba02 { get; set; }

    public int? PwdLiczba03 { get; set; }

    public int? PwdLiczba04 { get; set; }

    public int? PwdLiczba05 { get; set; }

    public int? PwdLiczba06 { get; set; }

    public int? PwdLiczba07 { get; set; }

    public int? PwdLiczba08 { get; set; }

    public int? PwdLiczba09 { get; set; }

    public int? PwdLiczba10 { get; set; }

    public string? PwdTekst01 { get; set; }

    public string? PwdTekst02 { get; set; }

    public string? PwdTekst03 { get; set; }

    public string? PwdTekst04 { get; set; }

    public string? PwdTekst05 { get; set; }

    public string? PwdTekst06 { get; set; }

    public string? PwdTekst07 { get; set; }

    public string? PwdTekst08 { get; set; }

    public string? PwdTekst09 { get; set; }

    public string? PwdTekst10 { get; set; }

    public decimal? PwdKwota01 { get; set; }

    public decimal? PwdKwota02 { get; set; }

    public decimal? PwdKwota03 { get; set; }

    public decimal? PwdKwota04 { get; set; }

    public decimal? PwdKwota05 { get; set; }

    public decimal? PwdKwota06 { get; set; }

    public decimal? PwdKwota07 { get; set; }

    public decimal? PwdKwota08 { get; set; }

    public decimal? PwdKwota09 { get; set; }

    public decimal? PwdKwota10 { get; set; }

    public int? PwdFk01 { get; set; }

    public int? PwdFk02 { get; set; }

    public int? PwdFk03 { get; set; }

    public int? PwdFk04 { get; set; }

    public int? PwdFk05 { get; set; }

    public int? PwdFk06 { get; set; }

    public int? PwdFk07 { get; set; }

    public int? PwdFk08 { get; set; }

    public int? PwdFk09 { get; set; }

    public int? PwdFk10 { get; set; }

    public bool? PwdFlaga01 { get; set; }

    public bool? PwdFlaga02 { get; set; }

    public bool? PwdFlaga03 { get; set; }

    public bool? PwdFlaga04 { get; set; }

    public bool? PwdFlaga05 { get; set; }

    public bool? PwdFlaga06 { get; set; }

    public bool? PwdFlaga07 { get; set; }

    public bool? PwdFlaga08 { get; set; }

    public bool? PwdFlaga09 { get; set; }

    public bool? PwdFlaga10 { get; set; }
}
