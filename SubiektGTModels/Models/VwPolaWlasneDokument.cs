﻿using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwPolaWlasneDokument
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