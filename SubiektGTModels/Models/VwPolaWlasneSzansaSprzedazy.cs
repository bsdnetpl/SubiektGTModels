using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwPolaWlasneSzansaSprzedazy
{
    public int TrId { get; set; }

    public int TrIdTransakcji { get; set; }

    public string TrNazwa { get; set; } = null!;

    public int TrKlient { get; set; }

    public int TrStan { get; set; }

    public int TrStatus { get; set; }

    public string? TrStatusOpis { get; set; }

    public int TrScenariusz { get; set; }

    public int TrEtap { get; set; }

    public int? TrPozyskana { get; set; }

    public DateTime TrDataOtwarcia { get; set; }

    public DateTime? TrPlanowanaDataZamkniecia { get; set; }

    public DateTime TrDataUtworzenia { get; set; }

    public int TrUtworzyl { get; set; }

    public DateTime? TrDataModyfikacji { get; set; }

    public int? TrZmodyfikowal { get; set; }

    public DateTime? TrDataZamkniecia { get; set; }

    public int? TrZamknal { get; set; }

    public int TrMaObsluzyc { get; set; }

    public int? TrMaObsluzycOdKlienta { get; set; }

    public int? TrOferta { get; set; }

    public decimal? TrWartoscNetto { get; set; }

    public decimal? TrWartoscBrutto { get; set; }

    public decimal? TrWartoscVat { get; set; }

    public string? TrWaluta { get; set; }

    public int? TrDokZamowienie { get; set; }

    public int? TrDokKoncowy { get; set; }

    public int? TrDokZamowienieId { get; set; }

    public int? TrDokKoncowyId { get; set; }

    public string? TrDokZamowienieSymbol { get; set; }

    public string? TrDokKoncowySymbol { get; set; }

    public int? TrGrupa { get; set; }

    public int? TrDlaczegoNieudana { get; set; }

    public bool? TrWartoscRecznie { get; set; }

    public decimal? TrWalutaKurs { get; set; }

    public string? TrWarunkiDostawy { get; set; }

    public string? TrWarunkiPlatnosci { get; set; }

    public string? TrUwagiDok { get; set; }

    public string? TrDataRealizacji { get; set; }

    public bool? TrPokazujWkal { get; set; }

    public string? TrKolor { get; set; }

    public int? TrPlanowanaGodzinaZamkniecia { get; set; }

    public int? TrZlecenieId { get; set; }

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
