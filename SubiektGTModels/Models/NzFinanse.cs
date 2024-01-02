using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzFinanse
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

    public int? NzfIdSyncDivision { get; set; }

    public bool NzfPrzedplataOddzial { get; set; }

    public int? NzfIdKarta { get; set; }

    public bool NzfPlatnoscKartaWoddziale { get; set; }

    public string? NzfTermPlatTerminalId { get; set; }

    public bool NzfVatRozliczanyPrzezUslugobiorce { get; set; }

    public virtual ICollection<NzFinanse> InverseNzfIdRozrachunkuNavigation { get; set; } = new List<NzFinanse>();

    public virtual ICollection<NzCesja> NzCesjaNzcIdCesyjnyNavigations { get; set; } = new List<NzCesja>();

    public virtual ICollection<NzCesja> NzCesjaNzcIdSplataNavigations { get; set; } = new List<NzCesja>();

    public virtual ICollection<NzFinanseHistoriaWindykacji> NzFinanseHistoriaWindykacjis { get; set; } = new List<NzFinanseHistoriaWindykacji>();

    public virtual ICollection<NzFinanseNotaPozycja> NzFinanseNotaPozycjas { get; set; } = new List<NzFinanseNotaPozycja>();

    public virtual ICollection<NzFinanseNotum> NzFinanseNotumNoIdNotyNavigations { get; set; } = new List<NzFinanseNotum>();

    public virtual ICollection<NzFinanseNotum> NzFinanseNotumNoIdRozrachunkuNavigations { get; set; } = new List<NzFinanseNotum>();

    public virtual ICollection<NzFinanseSplatum> NzFinanseSplatumNzsIdDluguNavigations { get; set; } = new List<NzFinanseSplatum>();

    public virtual ICollection<NzFinanseSplatum> NzFinanseSplatumNzsIdSplatyNavigations { get; set; } = new List<NzFinanseSplatum>();

    public virtual ICollection<NzKompensataPozycja> NzKompensataPozycjas { get; set; } = new List<NzKompensataPozycja>();

    public virtual ICollection<NzKorektaPit> NzKorektaPits { get; set; } = new List<NzKorektaPit>();

    public virtual ICollection<NzPowiaznaniePp> NzPowiaznaniePpNzpIdGlownyPpNavigations { get; set; } = new List<NzPowiaznaniePp>();

    public virtual ICollection<NzPowiaznaniePp> NzPowiaznaniePpNzpIdTechnicznyVatNavigations { get; set; } = new List<NzPowiaznaniePp>();

    public virtual ICollection<NzRaportKasowyDokumentKasowy> NzRaportKasowyDokumentKasowies { get; set; } = new List<NzRaportKasowyDokumentKasowy>();

    public virtual ICollection<NzRozDekret> NzRozDekrets { get; set; } = new List<NzRozDekret>();

    public virtual ICollection<NzWyciagBankowyOperacjaBankowa> NzWyciagBankowyOperacjaBankowas { get; set; } = new List<NzWyciagBankowyOperacjaBankowa>();

    public virtual PdUzytkownik? NzfFlagaZmianaPersonel { get; set; }

    public virtual AdrEwid? NzfIdAdresuNavigation { get; set; }

    public virtual SlWalutaBank? NzfIdBankuNavigation { get; set; }

    public virtual DokDokument? NzfIdDokumentAutoNavigation { get; set; }

    public virtual AdrHistorium? NzfIdHistoriiAdresuNavigation { get; set; }

    public virtual DksKasa? NzfIdKasyNavigation { get; set; }

    public virtual SlKategorium? NzfIdKategoriiNavigation { get; set; }

    public virtual RbRachBankowyHistorium? NzfIdRachunkuHistNavigation { get; set; }

    public virtual RbRachBankowy? NzfIdRachunkuNavigation { get; set; }

    public virtual RbRachBankowyWirtualny? NzfIdRachunkuWirtualnegoNavigation { get; set; }

    public virtual NzFinanse? NzfIdRozrachunkuNavigation { get; set; }

    public virtual SkSesja? NzfIdSesjiKasowejNavigation { get; set; }

    public virtual SlWalutum NzfIdWalutyNavigation { get; set; } = null!;

    public virtual ICollection<SpPlik> SpPliks { get; set; } = new List<SpPlik>();

    public virtual ICollection<SpTransakcja> SpTransakcjas { get; set; } = new List<SpTransakcja>();

    public virtual ICollection<ZdRozrachunek> ZdRozrachuneks { get; set; } = new List<ZdRozrachunek>();

    public virtual ICollection<ZdZadanie> ZdZadanies { get; set; } = new List<ZdZadanie>();

    public virtual ICollection<ZwRozrachunek> ZwRozrachuneks { get; set; } = new List<ZwRozrachunek>();
}
