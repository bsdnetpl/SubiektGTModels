using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwPolaWlasneKontrahent
{
    public int KhId { get; set; }

    public string KhSymbol { get; set; } = null!;

    public int KhRodzaj { get; set; }

    public string KhRegon { get; set; } = null!;

    public int? KhIdOdbiorca { get; set; }

    public string KhKontakt { get; set; } = null!;

    public string KhPesel { get; set; } = null!;

    public string KhNrDowodu { get; set; } = null!;

    public DateTime? KhDataWyd { get; set; }

    public string KhOrganWyd { get; set; } = null!;

    public bool KhCentrumAut { get; set; }

    public bool KhInstKredytowa { get; set; }

    public string KhPrefKontakt { get; set; } = null!;

    public string KhWww { get; set; } = null!;

    public string KhEmail { get; set; } = null!;

    public int? KhIdGrupa { get; set; }

    public int? KhIdFormaP { get; set; }

    public int? KhCena { get; set; }

    public bool KhPlatOdroczone { get; set; }

    public bool KhOdbDet { get; set; }

    public int? KhIdRabat { get; set; }

    public int KhMaxDokKred { get; set; }

    public decimal KhMaxWartDokKred { get; set; }

    public decimal KhMaxWartKred { get; set; }

    public int KhMaxDniSp { get; set; }

    public string KhNrAnalitykaD { get; set; } = null!;

    public string KhNrAnalitykaO { get; set; } = null!;

    public string KhUwagi { get; set; } = null!;

    public bool KhZgodaDo { get; set; }

    public int? KhIdOsobaDo { get; set; }

    public bool KhZgodaMark { get; set; }

    public bool KhZgodaEmail { get; set; }

    public bool KhCzyKomunikat { get; set; }

    public string KhKomunikat { get; set; } = null!;

    public bool KhKomunikatZawsze { get; set; }

    public DateTime? KhKomunikatOd { get; set; }

    public byte[]? KhGrafika { get; set; }

    public string KhPole1 { get; set; } = null!;

    public string KhPole2 { get; set; } = null!;

    public string KhPole3 { get; set; } = null!;

    public string KhPole4 { get; set; } = null!;

    public string KhPole5 { get; set; } = null!;

    public string KhPole6 { get; set; } = null!;

    public string KhPole7 { get; set; } = null!;

    public string KhPole8 { get; set; } = null!;

    public bool KhJednorazowy { get; set; }

    public string KhPracownik { get; set; } = null!;

    public bool KhZablokowany { get; set; }

    public bool KhAdresKoresp { get; set; }

    public bool KhUpowaznienieVat { get; set; }

    public DateTime? KhDataVat { get; set; }

    public int? KhOsobaVat { get; set; }

    public decimal KhProcKarta { get; set; }

    public decimal KhProcKredyt { get; set; }

    public decimal KhProcGotowka { get; set; }

    public decimal KhProcPozostalo { get; set; }

    public int? KhIdKategoriaKh { get; set; }

    public int? KhIdEwVatsp { get; set; }

    public int KhEwVatspMcOdliczenia { get; set; }

    public int? KhIdEwVatspKateg { get; set; }

    public int? KhIdEwVatzak { get; set; }

    public int KhEwVatzakRodzaj { get; set; }

    public int KhEwVatzakSposobOdliczenia { get; set; }

    public int KhEwVatzakMcOdliczenia { get; set; }

    public int? KhIdEwVatzakKateg { get; set; }

    public int? KhIdRachKategPrzychod { get; set; }

    public int? KhIdRachKategRozchod { get; set; }

    public int KhTransakcjaVatsp { get; set; }

    public int KhTransakcjaVatzak { get; set; }

    public bool KhPodVatzarejestrowanyWue { get; set; }

    public DateTime? KhDataWaznosciVat { get; set; }

    public string KhOpisOperacji { get; set; } = null!;

    public bool KhPlatPrzelew { get; set; }

    public string KhGaduGadu { get; set; } = null!;

    public string KhSkype { get; set; } = null!;

    public string KhPowitanie { get; set; } = null!;

    public bool KhAdresDostawy { get; set; }

    public int? KhIdRodzajKontaktu { get; set; }

    public int? KhIdPozyskany { get; set; }

    public int? KhIdBranza { get; set; }

    public int? KhIdRegion { get; set; }

    public int? KhLiczbaPrac { get; set; }

    public int? KhIdOpiekun { get; set; }

    public string KhImie { get; set; } = null!;

    public string KhNazwisko { get; set; } = null!;

    public bool KhCrm { get; set; }

    public bool KhPotencjalny { get; set; }

    public int? KhIdDodal { get; set; }

    public int? KhIdZmienil { get; set; }

    public DateTime? KhDataDodania { get; set; }

    public DateTime? KhDataZmiany { get; set; }

    public decimal KhProcPrzelew { get; set; }

    public DateTime? KhDataOkolicznosciowa { get; set; }

    public bool KhOsoba { get; set; }

    public int? KhIdRachunkuWirtualnego { get; set; }

    public string? KhKrs { get; set; }

    public string? KhDomena { get; set; }

    public int KhAkcyza { get; set; }

    public bool KhEfakturyZgoda { get; set; }

    public DateTime? KhEfakturyData { get; set; }

    public bool KhMetodaKasowa { get; set; }

    public string? KhLokalizacja { get; set; }

    public int KhStatusAkcyza { get; set; }

    public bool KhCzynnyPodatnikVat { get; set; }

    public bool? KhKorygowanieKup { get; set; }

    public bool? KhKorygowanieVatsp { get; set; }

    public bool? KhKorygowanieVatzak { get; set; }

    public int KhWzwIdFs { get; set; }

    public int KhWzwIdWz { get; set; }

    public int KhWzwIdWzvat { get; set; }

    public int KhWzwIdZk { get; set; }

    public int KhWzwIdZkzal { get; set; }

    public bool KhZgodaNewsletterVendero { get; set; }

    public bool KhKlientSklepuInternetowego { get; set; }

    public int KhWzwIdZd { get; set; }

    public int KhWzwIdCrmTransakcja { get; set; }

    public int? KhStawkaVatprzychod { get; set; }

    public int? KhStawkaVatwydatek { get; set; }

    public int? KhMalyPojazd { get; set; }

    public bool KhStosujRabatWmultistore { get; set; }

    public int KhCelZakupu { get; set; }

    public bool KhStosujIndywidualnyCennikWsklepieInternetowym { get; set; }

    public bool KhOdbiorcaCesjaPlatnosci { get; set; }

    public int? KhIdNabywca { get; set; }

    public int? KhIdOstatniWpisWeryfikacjiStatusuVat { get; set; }

    public bool KhBrakPpdlaRozrachunkowAuto { get; set; }

    public string? KhDomyslnaWaluta { get; set; }

    public int? KhDomyslnyTypCeny { get; set; }

    public int? KhDomyslnaTransVatsprzedaz { get; set; }

    public int? KhDomyslnaTransVatsprzedazFw { get; set; }

    public int? KhDomyslnaTransVatzakup { get; set; }

    public int? KhDomyslnaTransVatzakupFw { get; set; }

    public int? KhDomyslnyRachBankowyId { get; set; }

    public int? KhIdOstatniWpisWeryfikacjiStatusuVies { get; set; }

    public bool? KhDomyslnaWalutaMode { get; set; }

    public bool? KhDomyslnyRachBankowyIdMode { get; set; }

    public int? KhPrzypadekSzczegolnyPit { get; set; }

    public int? KhWartoscNettoCzyBrutto { get; set; }

    public bool KhStosujSzybkaPlatnosc { get; set; }

    public int? KhIdOstatniWpisWeryfikacjiWykazPodatnikowVat { get; set; }

    public int KhOstrzezenieTerminPlatnosciPrzekroczony { get; set; }

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
