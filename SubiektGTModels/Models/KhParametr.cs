using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhParametr
{
    public int KhpId { get; set; }

    public string KhpMiejscowosc { get; set; } = null!;

    public int? KhpGrupa { get; set; }

    public int? KhpIdWojewodztwo { get; set; }

    public int? KhpIdPanstwo { get; set; }

    public int? KhpIdRabat { get; set; }

    public string? KhpAnalitykaO { get; set; }

    public string? KhpAnalitykaD { get; set; }

    public bool KhpSymbolAuto { get; set; }

    public int? KhpDlugoscAuto { get; set; }

    public int KhpKolejnyAuto { get; set; }

    public int? KhpKolejnyWolny { get; set; }

    public int KhpAkcjaLiczba { get; set; }

    public int KhpAkcjaJeden { get; set; }

    public int KhpAkcjaWszystkie { get; set; }

    public int KhpAkcjaSpoznienie { get; set; }

    public bool KhpZezwalajOdroczone { get; set; }

    public int? KhpCena { get; set; }

    public bool KhpUstawiajZdjecia { get; set; }

    public decimal KhpProcGotowka { get; set; }

    public decimal KhpProcKarta { get; set; }

    public decimal KhpProcKredyt { get; set; }

    public decimal KhpProcPozostalo { get; set; }

    public int? KhpIdTermin { get; set; }

    public string KhpKodPocztowy { get; set; } = null!;

    public int? KhpIdKategoriaKh { get; set; }

    public int? KhpIdEwVatsp { get; set; }

    public int KhpEwVatspMcOdliczenia { get; set; }

    public int? KhpIdEwVatspKateg { get; set; }

    public int? KhpIdEwVatzak { get; set; }

    public int KhpEwVatzakRodzaj { get; set; }

    public int KhpEwVatzakSposobOdliczenia { get; set; }

    public int KhpEwVatzakMcOdliczenia { get; set; }

    public int? KhpIdEwVatzakKateg { get; set; }

    public int? KhpIdRachKategPrzychod { get; set; }

    public int? KhpIdRachKategRozchod { get; set; }

    public int KhpTransakcjaVatsp { get; set; }

    public int KhpTransakcjaVatzak { get; set; }

    public int KhpRodzaj { get; set; }

    public bool KhpJednZezwalajOdroczone { get; set; }

    public decimal KhpJednProcKarta { get; set; }

    public decimal KhpJednProcKredyt { get; set; }

    public decimal KhpJednProcGotowka { get; set; }

    public decimal KhpJednProcPozostalo { get; set; }

    public int? KhpJednIdTermin { get; set; }

    public int KhpMaxDokKred { get; set; }

    public decimal KhpMaxWartDokKred { get; set; }

    public decimal KhpMaxWartKred { get; set; }

    public int KhpMaxDniSp { get; set; }

    public bool KhpOdbDet { get; set; }

    public int KhpKontrolaNip { get; set; }

    public int? KhpParamEwidId { get; set; }

    public int? KhpIdRegion { get; set; }

    public bool KhpPotencjalny { get; set; }

    public decimal KhpProcPrzelew { get; set; }

    public decimal KhpJednProcPrzelew { get; set; }

    public bool KhpOpiekun { get; set; }

    public bool KhpOsoba { get; set; }

    public bool KhpOsobaOdbDetal { get; set; }

    public bool KhpStosujAkcjeDoZk { get; set; }

    public bool KhpStosujAkcjeDoWz { get; set; }

    public int KhpKontrolaPesel { get; set; }

    public bool KhpKhUprJakoOdb { get; set; }

    public bool KhpKhUprPustyAdres { get; set; }

    public int KhpAdresKolejnosc { get; set; }

    public string? KhpLokalizacja1 { get; set; }

    public string? KhpLokalizacja2 { get; set; }

    public string? KhpLokalizacja3 { get; set; }

    public string? KhpLokalizacja4 { get; set; }

    public string? KhpLokalizacja5 { get; set; }

    public int KhpStatusAkcyza { get; set; }

    public int KhpKhJednStatusAkcyza { get; set; }

    public bool KhpCzynnyPodatnikVat { get; set; }

    public bool KhpKhJednCzynnyPodatnikVat { get; set; }

    public bool KhpFormatujDaneGus { get; set; }

    public int KhpNazwaUzupelnij { get; set; }

    public bool KhpPocztaMiejscowoscZamien { get; set; }

    public bool KhpGusNowaWyszukiwarka { get; set; }

    public bool KhpGusDaneKontaktowe { get; set; }

    public bool KhpFormatujNazweZgus { get; set; }

    public bool KhpKlientSklepuInternetowego { get; set; }

    public bool KhpStosujRabatWmultistore { get; set; }

    public int? KhpMalyPojazd { get; set; }

    public int KhpCelZakupu { get; set; }

    public bool KhpDrukujZgodyNowy { get; set; }

    public bool KhpDrukujZgodyEdycja { get; set; }

    public bool KhpDrukujZgodyWybor { get; set; }

    public int? KhpPrzypadekSzczegolnyPit { get; set; }

    public int? KhpWartoscNettoCzyBrutto { get; set; }

    public bool KhpStosujSzybkaPlatnosc { get; set; }

    public bool KhpSprawdzajStatusVatwportaluPodatkowym { get; set; }

    public int KhpOstrzezenieTerminPlatnosciPrzekroczony { get; set; }

    public bool KhpJednStosujDomyslneOznaczeniaJpk { get; set; }

    public bool KhpSw { get; set; }

    public bool KhpEe { get; set; }

    public bool KhpTp { get; set; }

    public bool KhpTtWnt { get; set; }

    public bool KhpTtD { get; set; }

    public bool KhpMrT { get; set; }

    public bool KhpMrUz { get; set; }

    public bool KhpI42 { get; set; }

    public bool KhpI63 { get; set; }

    public bool KhpBSpv { get; set; }

    public bool KhpBSpvDostawa { get; set; }

    public bool KhpBMpvProwizja { get; set; }

    public bool KhpGtu1 { get; set; }

    public bool KhpGtu2 { get; set; }

    public bool KhpGtu3 { get; set; }

    public bool KhpGtu4 { get; set; }

    public bool KhpGtu5 { get; set; }

    public bool KhpGtu6 { get; set; }

    public bool KhpGtu7 { get; set; }

    public bool KhpGtu8 { get; set; }

    public bool KhpGtu9 { get; set; }

    public bool KhpGtu10 { get; set; }

    public bool KhpGtu11 { get; set; }

    public bool KhpGtu12 { get; set; }

    public bool KhpGtu13 { get; set; }

    public int KhpPodatekCukrowyNaliczaj { get; set; }

    public int KhpKhJednPodatekCukrowyNaliczaj { get; set; }

    public bool KhpWstoEe { get; set; }

    public bool KhpIed { get; set; }

    public bool KhpStosujAkcjeWliczajNiepowiazaneWz { get; set; }

    public virtual SlKategorium? KhpIdEwVatspKategNavigation { get; set; }

    public virtual SlTypEwidVat? KhpIdEwVatspNavigation { get; set; }

    public virtual SlKategorium? KhpIdEwVatzakKategNavigation { get; set; }

    public virtual SlTypEwidVat? KhpIdEwVatzakNavigation { get; set; }

    public virtual SlKategorium? KhpIdKategoriaKhNavigation { get; set; }

    public virtual SlPanstwo? KhpIdPanstwoNavigation { get; set; }

    public virtual SlRabat? KhpIdRabatNavigation { get; set; }

    public virtual SlKategorium? KhpIdRachKategPrzychodNavigation { get; set; }

    public virtual SlKategorium? KhpIdRachKategRozchodNavigation { get; set; }

    public virtual SlCrmRegion? KhpIdRegionNavigation { get; set; }

    public virtual SlFormaPlatnosci? KhpIdTerminNavigation { get; set; }

    public virtual SlWojewodztwo? KhpIdWojewodztwoNavigation { get; set; }

    public virtual ParEwid? KhpParamEwid { get; set; }
}
