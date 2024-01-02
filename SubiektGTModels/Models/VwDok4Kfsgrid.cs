using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDok4Kfsgrid
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

    public decimal? DokPrzedplata { get; set; }

    public DateTime? SsDataZamkniecia { get; set; }

    public DateTime? SsDataBlokadyRach { get; set; }

    public int? LspStatus { get; set; }

    public decimal? DokKwKartaPrzedplata { get; set; }

    public int? DokTypDatyUjeciaKorekty { get; set; }

    public DateTime? DokDataUjeciaKorekty { get; set; }

    public string? DokNumerKseF { get; set; }

    public DateTime? DokDataNumeruKseF { get; set; }

    public int DokStatusKseF { get; set; }

    public decimal? DokKwWartoscWwalucie { get; set; }

    public string? DokBladKseF { get; set; }

    public int DokJestKseFupo { get; set; }

    public int DokFormaDokumentowania { get; set; }

    public bool DokCzekaNaKseF { get; set; }
}
