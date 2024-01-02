using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokDokument
{
    public int DokId { get; set; }

    public int DokTyp { get; set; }

    public int DokPodtyp { get; set; }

    public int? DokMagId { get; set; }

    public int? DokNr { get; set; }

    public string? DokNrRoz { get; set; }

    public string DokNrPelny { get; set; } = null!;

    public string DokNrPelnyOryg { get; set; } = null!;

    public int? DokDoDokId { get; set; }

    public string DokDoDokNrPelny { get; set; } = null!;

    public DateTime? DokDoDokDataWyst { get; set; }

    public string DokMscWyst { get; set; } = null!;

    public DateTime DokDataWyst { get; set; }

    public DateTime DokDataMag { get; set; }

    public DateTime? DokDataOtrzym { get; set; }

    public int? DokPlatnikId { get; set; }

    public int? DokPlatnikAdreshId { get; set; }

    public int? DokOdbiorcaId { get; set; }

    public int? DokOdbiorcaAdreshId { get; set; }

    public int? DokPlatId { get; set; }

    public DateTime? DokPlatTermin { get; set; }

    public string DokWystawil { get; set; } = null!;

    public string DokOdebral { get; set; } = null!;

    public int? DokPersonelId { get; set; }

    public int? DokCenyPoziom { get; set; }

    public int? DokCenyTyp { get; set; }

    public decimal? DokCenyKurs { get; set; }

    public decimal DokCenyNarzut { get; set; }

    public decimal DokRabatProc { get; set; }

    public decimal DokWartUsNetto { get; set; }

    public decimal DokWartUsBrutto { get; set; }

    public decimal DokWartTwNetto { get; set; }

    public decimal DokWartTwBrutto { get; set; }

    public decimal DokWartOpZwr { get; set; }

    public decimal DokWartOpWyd { get; set; }

    public decimal DokWartMag { get; set; }

    public decimal DokWartMagP { get; set; }

    public decimal DokWartMagR { get; set; }

    public decimal DokWartNetto { get; set; }

    public decimal DokWartVat { get; set; }

    public decimal DokWartBrutto { get; set; }

    public decimal? DokKwWartosc { get; set; }

    public decimal? DokKwGotowka { get; set; }

    public decimal? DokKwKarta { get; set; }

    public decimal? DokKwDoZaplaty { get; set; }

    public decimal? DokKwKredyt { get; set; }

    public decimal? DokKwReszta { get; set; }

    public string? DokWaluta { get; set; }

    public decimal DokWalutaKurs { get; set; }

    public string DokUwagi { get; set; } = null!;

    public int? DokKatId { get; set; }

    public string DokTytul { get; set; } = null!;

    public string DokPodtytul { get; set; } = null!;

    public int DokStatus { get; set; }

    public int DokStatusKsieg { get; set; }

    public int DokStatusFiskal { get; set; }

    public bool DokStatusBlok { get; set; }

    public bool DokJestTylkoDoOdczytu { get; set; }

    public bool DokJestRuchMag { get; set; }

    public bool DokJestZmianaDatyDokKas { get; set; }

    public bool DokJestHop { get; set; }

    public bool DokJestVatNaEksport { get; set; }

    public bool DokJestVatAuto { get; set; }

    public int DokAlgorytm { get; set; }

    public int? DokKartaId { get; set; }

    public int? DokKredytId { get; set; }

    public int DokRodzajOperacjiVat { get; set; }

    public int? DokKodRodzajuTransakcji { get; set; }

    public int? DokStatusEx { get; set; }

    public int? DokObiektGt { get; set; }

    public bool DokRozliczony { get; set; }

    public int? DokRejId { get; set; }

    public DateTime? DokTerminRealizacji { get; set; }

    public int DokWalutaLiczbaJednostek { get; set; }

    public int? DokWalutaRodzajKursu { get; set; }

    public DateTime? DokWalutaDataKursu { get; set; }

    public int? DokWalutaIdBanku { get; set; }

    public int DokCenyLiczbaJednostek { get; set; }

    public int? DokCenyRodzajKursu { get; set; }

    public DateTime? DokCenyDataKursu { get; set; }

    public int? DokCenyIdBanku { get; set; }

    public decimal? DokKwPrzelew { get; set; }

    public decimal? DokKwGotowkaPrzedplata { get; set; }

    public decimal? DokKwPrzelewPrzedplata { get; set; }

    public int? DokDefiniowalnyId { get; set; }

    public int? DokTransakcjaId { get; set; }

    public string? DokTransakcjaSymbol { get; set; }

    public DateTime? DokTransakcjaData { get; set; }

    public int? DokPodsumaVatFszk { get; set; }

    public int? DokZlecenieId { get; set; }

    public bool DokNaliczajFundusze { get; set; }

    public bool? DokPrzetworzonoZkwZd { get; set; }

    public bool? DokVatMarza { get; set; }

    public int? DokDstNr { get; set; }

    public string? DokDstNrRoz { get; set; }

    public string? DokDstNrPelny { get; set; }

    public int? DokObslugaDokDost { get; set; }

    public int? DokAkcyzaZwolnienieId { get; set; }

    public int DokProceduraMarzy { get; set; }

    public bool DokFakturaUproszczona { get; set; }

    public DateTime? DokDataZakonczenia { get; set; }

    public bool DokMetodaKasowa { get; set; }

    public int DokTypNrIdentNabywcy { get; set; }

    public string? DokNrIdentNabywcy { get; set; }

    public int? DokAdresDostawyId { get; set; }

    public int? DokAdresDostawyAdreshId { get; set; }

    public int? DokVenderoId { get; set; }

    public string? DokVenderoSymbol { get; set; }

    public DateTime? DokVenderoData { get; set; }

    public int? DokSelloId { get; set; }

    public string? DokSelloSymbol { get; set; }

    public DateTime? DokSelloData { get; set; }

    public int? DokTransakcjaJednolitaId { get; set; }

    public bool? DokPodpisanoElektronicznie { get; set; }

    public string DokUwagiExt { get; set; } = null!;

    public int? DokVenderoStatus { get; set; }

    public bool? DokZaimportowanoDoEwidencjiAkcyzowej { get; set; }

    public int? DokTermPlatStatus { get; set; }

    public string? DokTermPlatTransId { get; set; }

    public bool DokDokumentFiskalnyDlaPodatnikaVat { get; set; }

    public bool DokCesjaPlatnikOdbiorca { get; set; }

    public decimal DokWartOplRecykl { get; set; }

    public int? DokTermPlatIdKonfig { get; set; }

    public int? DokTermPlatIdZadania { get; set; }

    public int? DokPromoZenCardStatus { get; set; }

    public int? DokNrRachunkuBankowegoPdm { get; set; }

    public bool DokSzybkaPlatnosc { get; set; }

    public bool DokMechanizmPodzielonejPlatnosci { get; set; }

    public int? DokIdSesjiKasowej { get; set; }

    public decimal? DokKwKartaPrzedplata { get; set; }

    public int? DokIdPanstwaRozpoczeciaWysylki { get; set; }

    public int? DokIdPanstwaKonsumenta { get; set; }

    public string? DokInformacjeDodatkowe { get; set; }

    public bool DokZnacznikiGtunaPozycji { get; set; }

    public int? DokTypDatyUjeciaKorekty { get; set; }

    public DateTime? DokDataUjeciaKorekty { get; set; }

    public int? DokIdPrzyczynyZwolnieniaZvat { get; set; }

    public string? DokNumerKseF { get; set; }

    public DateTime? DokDataNumeruKseF { get; set; }

    public string? DokDoNumerKseF { get; set; }

    public int? DokKodRodzajuTransportu { get; set; }

    public string DokDodatkoweInfoRodzajuTransportu { get; set; } = null!;

    public string DokCzasWysylkiTransportu { get; set; } = null!;

    public string DokCzasPrzewozuTransportu { get; set; } = null!;

    public int DokStatusKseF { get; set; }

    public bool DokKorektaDanychNabywcy { get; set; }

    public string? DokSesjaKseF { get; set; }

    public string? DokIdPrzetwarzaniaKseF { get; set; }

    public int? DokSrodowiskoKseF { get; set; }

    public string? DokBladKseF { get; set; }

    public DateTime? DokDataRozpoczeciaPrzetwarzaniaKseF { get; set; }

    public string? DokWegielNumerOswiadczenia { get; set; }

    public string? DokXmlHashKseF { get; set; }

    public string? DokTermPlatTerminalId { get; set; }

    public string? DokFiskalizacjaNumer { get; set; }

    public DateTime? DokFiskalizacjaData { get; set; }

    public string? DokFiskalizacjaIdUrzadzenia { get; set; }

    public int? DokSesjaKseFid { get; set; }

    public DateTime? DokDataWystawieniaKseF { get; set; }

    public int DokFormaDokumentowania { get; set; }

    public bool DokCzekaNaKseF { get; set; }

    public bool DokVatRozliczanyPrzezUslugobiorce { get; set; }

    public bool DokPodlegaOplSpec { get; set; }

    public string? DokDataNumeruKseForyg { get; set; }

    public virtual ICollection<DfwPozycja> DfwPozycjas { get; set; } = new List<DfwPozycja>();

    public virtual ICollection<DokDokBiblioteka> DokDokBibliotekas { get; set; } = new List<DokDokBiblioteka>();

    public virtual SlPanstwo? DokIdPanstwaKonsumentaNavigation { get; set; }

    public virtual SlPanstwo? DokIdPanstwaRozpoczeciaWysylkiNavigation { get; set; }

    public virtual SlZwolnienieZvat? DokIdPrzyczynyZwolnieniaZvatNavigation { get; set; }

    public virtual SkSesja? DokIdSesjiKasowejNavigation { get; set; }

    public virtual SlKategorium? DokKat { get; set; }

    public virtual SlKodRodzajuTransportuEdd? DokKodRodzajuTransportuNavigation { get; set; }

    public virtual RbRachBankowy? DokNrRachunkuBankowegoPdmNavigation { get; set; }

    public virtual ICollection<DokPozycja> DokPozycjaObDokHans { get; set; } = new List<DokPozycja>();

    public virtual ICollection<DokPozycja> DokPozycjaObDokMags { get; set; } = new List<DokPozycja>();

    public virtual KsefSesja? DokSesjaKseFNavigation { get; set; }

    public virtual DokStatusWydruku? DokStatusWydruku { get; set; }

    public virtual ICollection<DokVat> DokVats { get; set; } = new List<DokVat>();

    public virtual ICollection<EddEdokDostawy> EddEdokDostawies { get; set; } = new List<EddEdokDostawy>();

    public virtual ICollection<IwDokument> IwDokumentIwPws { get; set; } = new List<IwDokument>();

    public virtual ICollection<IwDokument> IwDokumentIwRws { get; set; } = new List<IwDokument>();

    public virtual ICollection<KorPozycja> KorPozycjas { get; set; } = new List<KorPozycja>();

    public virtual ICollection<KsefFakturyHandel> KsefFakturyHandels { get; set; } = new List<KsefFakturyHandel>();

    public virtual ICollection<LspLinkDoSzybkiejPlatnosci> LspLinkDoSzybkiejPlatnoscis { get; set; } = new List<LspLinkDoSzybkiejPlatnosci>();

    public virtual ICollection<NzFinanse> NzFinanses { get; set; } = new List<NzFinanse>();

    public virtual ICollection<RfPozycja> RfPozycjas { get; set; } = new List<RfPozycja>();

    public virtual ICollection<ZdZadanie> ZdZadanies { get; set; } = new List<ZdZadanie>();
}
