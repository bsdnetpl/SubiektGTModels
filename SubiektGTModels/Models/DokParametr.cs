using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokParametr
{
    public int DkpTyp { get; set; }

    public int DkpPodtyp { get; set; }

    public int? DkpKatId { get; set; }

    public string DkpTytul { get; set; } = null!;

    public string DkpPodtytul { get; set; } = null!;

    public int DkpMscWystTyp { get; set; }

    public string DkpMscWyst { get; set; } = null!;

    public int? DkpPlatnId { get; set; }

    public int? DkpCenyPoziom { get; set; }

    public int? DkpCenyTyp { get; set; }

    public int? DkpWalutaKursTyp { get; set; }

    public int? DkpCenyPoziomZwr { get; set; }

    public int? DkpSpLiczVat { get; set; }

    public int? DkpKontrolaWart { get; set; }

    public int? DkpProg { get; set; }

    public decimal? DkpWartProgu { get; set; }

    public int? DkpSortuj { get; set; }

    public int? DkpKasaKatId { get; set; }

    public int? DkpWzkatId { get; set; }

    public string DkpWztytul { get; set; } = null!;

    public string DkpWzpodtytul { get; set; } = null!;

    public int? DkpPzkatId { get; set; }

    public string DkpPztytul { get; set; } = null!;

    public string DkpPzpodtytul { get; set; } = null!;

    public bool? DkpFiskalizuj { get; set; }

    public int? DkpDrukarkaId { get; set; }

    public bool? DkpPrzeliczNetto { get; set; }

    public bool DkpRezerwuj { get; set; }

    public bool DkpDrukuj { get; set; }

    public bool DkpDrukujAuto { get; set; }

    public bool DkpReszta { get; set; }

    public bool DkpNalZob { get; set; }

    public decimal DkpCenyNarzut { get; set; }

    public int DkpRodzajOperacjiVat { get; set; }

    public bool DkpPrzeniesUwagi { get; set; }

    public int? DkpKodRodzajuTransakcji { get; set; }

    public bool DkpPlaOdb { get; set; }

    public string DkpPlaOdbSql { get; set; } = null!;

    public bool DkpZamRoznWartMin { get; set; }

    public bool DkpDrukujInwBezZapisu { get; set; }

    public bool DkpPobierajOstatniKurs { get; set; }

    public int DkpTypDatyKursu { get; set; }

    public bool DkpSumGrid { get; set; }

    public bool DkpKorektaN { get; set; }

    public int? DkpParamEwidId { get; set; }

    public bool? DkpSzuflada { get; set; }

    public int DkpInsxLiczbaPozTw { get; set; }

    public bool DkpInsxTwBezZerowych { get; set; }

    public bool DkpInsxTwRezerwacje { get; set; }

    public bool DkpInsxTwWarunekAnd { get; set; }

    public bool DkpInsxTwSortuj { get; set; }

    public int DkpInsxLiczbaPozKh { get; set; }

    public bool DkpInsxKhWarunekAnd { get; set; }

    public int DkpInsxKhRodzaj { get; set; }

    public bool DkpInsxKhSortuj { get; set; }

    public int? DkpBankKatId { get; set; }

    public int DkpDefiniowalnyId { get; set; }

    public int? DkpDomyslnaKategoria { get; set; }

    public int DkpInwDomyslnyStan { get; set; }

    public decimal? DkpInwDomyslnyStanWartosc { get; set; }

    public bool DkpInwTrybZwykly { get; set; }

    public bool DkpInwTrybAuto { get; set; }

    public bool DkpBlokujZwykleZk { get; set; }

    public int DkpRejFiskPozycjeFaktZal { get; set; }

    public int DkpInwCenyIwz { get; set; }

    public bool DkpInwKodyDostaw { get; set; }

    public bool DkpInwPokazRaport { get; set; }

    public int DkpFwKontrolaTyp { get; set; }

    public int DkpFwVatTyp { get; set; }

    public bool DkpFwWszystkiePozycje { get; set; }

    public bool DkpInwRaportNiezerowe { get; set; }

    public bool DkpNaliczajFunduszePromocji { get; set; }

    public bool DkpFwOdliczenieAuto { get; set; }

    public int DkpZamRoznicTrybRealiz { get; set; }

    public bool DkpFwKorektyRoznicowo { get; set; }

    public bool DkpZamRoznMagNieGrupuj { get; set; }

    public bool DkpDodajAkcyzeDoNetto { get; set; }

    public bool DkpVatMarza { get; set; }

    public int DkpFmFiskVatId { get; set; }

    public bool DkpCzyDzialanieDodaj { get; set; }

    public bool DkpCzyDzialanieEdycja { get; set; }

    public int DkpRodzajDzialanieDodaj { get; set; }

    public int DkpRodzajDzialanieEdycja { get; set; }

    public int? DkpSzablonDzialanieDodaj { get; set; }

    public int? DkpSzablonDzialanieEdycja { get; set; }

    public bool DkpPodpisujPdf { get; set; }

    public bool DkpDodajDoBiblioteki { get; set; }

    public int DkpPodpisBrakZgodyKh { get; set; }

    public int DkpKontrolaPozycjiIwc { get; set; }

    public int? DkpTypKartotKhFsu { get; set; }

    public int DkpProceduraMarzy { get; set; }

    public int? DkpKatIdFsu { get; set; }

    public int? DkpKontrolaOkrDokMagFk { get; set; }

    public bool DkpIwzEdycjaPwRw { get; set; }

    public int DkpRodzajZwrDetal { get; set; }

    public int DkpKontrolaWystDokWaluta { get; set; }

    public bool DkpRejFiskUsuwajPozycjeZeroweFaktZb { get; set; }

    public bool DkpFwPobierajPozycjezOo { get; set; }

    public int DkpPozDomyslnyStan { get; set; }

    public decimal DkpPozDomyslnyStanWartosc { get; set; }

    public bool DkpPozTrybZwykly { get; set; }

    public bool DkpPozTrybAuto { get; set; }

    public bool DkpBlokujPoprawPaGdyFsd { get; set; }

    public bool DkpBlokujUsunPaGdyFsd { get; set; }

    public bool DkpBlokujDodajZwGdyFsd { get; set; }

    public bool DkpBlokujEdycjaFsd { get; set; }

    public bool DkpDoFsdWlaczZwrDet { get; set; }

    public bool DkpBlokujPoprawZwGdyFsd { get; set; }

    public bool DkpBlokujUsunZwGdyFsd { get; set; }

    public bool DkpCzyEdycjaNabyciaMarza { get; set; }

    public int DkpUtrzymujCeneNettoBrutto { get; set; }

    public bool DkpUzyjAdresuDostawy { get; set; }

    public bool DkpCenyPrecyzjaZwykla { get; set; }

    public bool DkpDataMagZakupuJakZakonczenia { get; set; }

    public int? DkpDomyslnaKatDlaUsJednorazowych { get; set; }

    public bool DkpZapiszKontynuuj { get; set; }

    public bool DkpNiePrzenosUwagZam { get; set; }

    public int DkpAutoAktualizacjaCenTryb { get; set; }

    public int DkpAutoAktualizacjaCenKryterium { get; set; }

    public int DkpAutoAktualizacjaCenKwotaKryterium { get; set; }

    public decimal DkpAutoAktualizacjaCenKwota { get; set; }

    public bool DkpAutoAktualizacaCenTylkoOstatni { get; set; }

    public bool DkpAutoAktualizacaCenTowaryKryteria { get; set; }

    public bool DkpDataOtrzymaniaJakoDataDlaBlokadyOkresu { get; set; }

    public bool? DkpTerminalPlatniczy { get; set; }

    public bool? DkpTerminalPlatniczyAuto { get; set; }

    public bool DkpPrzeliczajPozycjePoKazdejZmianieKontrahenta { get; set; }

    public int DkpZamRealizacjaZpodlWz { get; set; }

    public bool DkpInwZbWydrukWartosciRoznicStanowZdokMag { get; set; }

    public int DkpPokazujOdbiorceWsekcjiNabywcy { get; set; }

    public int DkpTerminalPlatniczyTryb { get; set; }

    public int DkpTerminalPlatniczyStatusBrakStanow { get; set; }

    public int DkpBlokadaDlaKontrahentaBezNip { get; set; }

    public int DkpFwKontrolaWieluFaktur { get; set; }

    public int DkpBlokadaDlaPowielonegoNrOryg { get; set; }

    public int DkpSposobWystawiania { get; set; }

    public bool DkpNieDrukujDokumentu { get; set; }

    public int DkpKontrolaFsdDoPabezNip { get; set; }

    public int DkpAutoZnacznikFpdlaJpkVat { get; set; }

    public int DkpOplataCukrowaNaliczaj { get; set; }

    public bool DkpOplataCukrowaDodawajDoCeny { get; set; }

    public int DkpKontrolaFsdNipMaxKwota { get; set; }

    public int? DkpInwLiczbaDniDoIgnorowaniaOstrzezeniaStatusMag { get; set; }

    public bool? DkpInwStatusMagOstrzegaj { get; set; }

    public int DkpNzokres { get; set; }

    public int DkpNztransakcjaVat { get; set; }

    public bool DkpOplataCukrowaDodawajDoCenyNieOgraniczaj { get; set; }

    public int DkpTypDatyUjeciaKorekty { get; set; }

    public int DkpKsefWydrukBezNrBlokujOstrzegaj { get; set; }

    public string? DkpKsefWydrukBezNrTytul { get; set; }

    public int DkpKsefWydrukowanyBlokujOstrzegaj { get; set; }

    public int DkpFormaDokumentowania { get; set; }

    public bool DkpZaznaczajVatRozliczanyPrzezUslugobiorce { get; set; }

    public virtual ParEwid? DkpParamEwid { get; set; }
}
