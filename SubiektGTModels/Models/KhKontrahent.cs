using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhKontrahent
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

    public int KhPodatekCukrowyNaliczaj { get; set; }

    public string? KhNrAkcyzowy { get; set; }

    public int KhWzwIdKfs { get; set; }

    public int? KhKsefEksportObslugaPolaDodatkoweInformacje { get; set; }

    public int? KhKsefImportObslugaPolaDodatkoweInformacje { get; set; }

    public int? KhKsefMagazynDlaEfaktur { get; set; }

    public bool KhKsefDodatkoweInfoPoprzedzEtykietaPola { get; set; }

    public string? KhKsefPoleDodatkoweInformacjeEksportSql { get; set; }

    public bool KhKsefPoleDodatkoweInformacjeEksportNaPodstSql { get; set; }

    public int? KhDomyslnaFormaDokumentowaniaSprzedaz { get; set; }

    public int? KhKsefDomyslnyEtapPrzetwarzania { get; set; }

    public bool KhVatRozliczanyPrzezUslugobiorce { get; set; }

    public bool KhVatRozliczanyPrzezUslugobiorceFw { get; set; }

    public bool KhProducentRolny { get; set; }

    public bool KhNaliczajOplSpec { get; set; }

    public virtual ICollection<DkrDokument> DkrDokuments { get; set; } = new List<DkrDokument>();

    public virtual ICollection<DpDokument> DpDokuments { get; set; } = new List<DpDokument>();

    public virtual ICollection<IcenCennikKontrahent> IcenCennikKontrahents { get; set; } = new List<IcenCennikKontrahent>();

    public virtual ICollection<ImSchematImportuKontrahent> ImSchematImportuKontrahents { get; set; } = new List<ImSchematImportuKontrahent>();

    public virtual ICollection<KhKontrahent> InverseKhIdNabywcaNavigation { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhKontrahent> InverseKhIdOdbiorcaNavigation { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhAdresyDostawy> KhAdresyDostawies { get; set; } = new List<KhAdresyDostawy>();

    public virtual ICollection<KhCechaKh> KhCechaKhs { get; set; } = new List<KhCechaKh>();

    public virtual ICollection<KhDokument> KhDokuments { get; set; } = new List<KhDokument>();

    public virtual SlWalutum? KhDomyslnaWalutaNavigation { get; set; }

    public virtual RbRachBankowy? KhDomyslnyRachBankowy { get; set; }

    public virtual SlCrmBranza? KhIdBranzaNavigation { get; set; }

    public virtual SlKategorium? KhIdEwVatspKategNavigation { get; set; }

    public virtual SlTypEwidVat? KhIdEwVatspNavigation { get; set; }

    public virtual SlKategorium? KhIdEwVatzakKategNavigation { get; set; }

    public virtual SlTypEwidVat? KhIdEwVatzakNavigation { get; set; }

    public virtual SlFormaPlatnosci? KhIdFormaPNavigation { get; set; }

    public virtual SlGrupaKh? KhIdGrupaNavigation { get; set; }

    public virtual SlKategorium? KhIdKategoriaKhNavigation { get; set; }

    public virtual KhKontrahent? KhIdNabywcaNavigation { get; set; }

    public virtual KhKontrahent? KhIdOdbiorcaNavigation { get; set; }

    public virtual PdUzytkownik? KhIdOpiekunNavigation { get; set; }

    public virtual KhWeryfikacjaNip? KhIdOstatniWpisWeryfikacjiStatusuVatNavigation { get; set; }

    public virtual KhVy? KhIdOstatniWpisWeryfikacjiStatusuViesNavigation { get; set; }

    public virtual SlCrmZrodloPozyskanium? KhIdPozyskanyNavigation { get; set; }

    public virtual SlRabat? KhIdRabatNavigation { get; set; }

    public virtual SlKategorium? KhIdRachKategPrzychodNavigation { get; set; }

    public virtual SlKategorium? KhIdRachKategRozchodNavigation { get; set; }

    public virtual RbRachBankowyWirtualny? KhIdRachunkuWirtualnegoNavigation { get; set; }

    public virtual SlCrmRegion? KhIdRegionNavigation { get; set; }

    public virtual SlRodzajKontaktu? KhIdRodzajKontaktuNavigation { get; set; }

    public virtual ICollection<KhKategoriaDokumentu> KhKategoriaDokumentus { get; set; } = new List<KhKategoriaDokumentu>();

    public virtual ICollection<KhPracownik> KhPracowniks { get; set; } = new List<KhPracownik>();

    public virtual ICollection<KhRachunkiBankoweHistoriaWeryfikacjiBialaListum> KhRachunkiBankoweHistoriaWeryfikacjiBialaLista { get; set; } = new List<KhRachunkiBankoweHistoriaWeryfikacjiBialaListum>();

    public virtual ICollection<KhTransakcjaJednolitum> KhTransakcjaJednolita { get; set; } = new List<KhTransakcjaJednolitum>();

    public virtual ICollection<KhVy> KhVies { get; set; } = new List<KhVy>();

    public virtual ICollection<KhWeryfikacjaNip> KhWeryfikacjaNips { get; set; } = new List<KhWeryfikacjaNip>();

    public virtual ICollection<KhWeryfikacjaWykazPodatnikowVat> KhWeryfikacjaWykazPodatnikowVats { get; set; } = new List<KhWeryfikacjaWykazPodatnikowVat>();

    public virtual ICollection<KprKsiega> KprKsiegas { get; set; } = new List<KprKsiega>();

    public virtual ICollection<KsefFakturyKsiegowosc> KsefFakturyKsiegowoscs { get; set; } = new List<KsefFakturyKsiegowosc>();

    public virtual ICollection<LspLinkDoSzybkiejPlatnosci> LspLinkDoSzybkiejPlatnoscis { get; set; } = new List<LspLinkDoSzybkiejPlatnosci>();

    public virtual ICollection<MiKhPomijany> MiKhPomijanies { get; set; } = new List<MiKhPomijany>();

    public virtual ICollection<MiSprzedazParametr> MiSprzedazParametrs { get; set; } = new List<MiSprzedazParametr>();

    public virtual ICollection<MiSprzedaz> MiSprzedazs { get; set; } = new List<MiSprzedaz>();

    public virtual ICollection<OssEwid> OssEwids { get; set; } = new List<OssEwid>();

    public virtual ICollection<PbDokument> PbDokuments { get; set; } = new List<PbDokument>();

    public virtual ICollection<PojEksploatacja> PojEksploatacjas { get; set; } = new List<PojEksploatacja>();

    public virtual ICollection<PrzPrzychod> PrzPrzychods { get; set; } = new List<PrzPrzychod>();

    public virtual ICollection<RbRachBankowyWirtualnyKontrahentum> RbRachBankowyWirtualnyKontrahenta { get; set; } = new List<RbRachBankowyWirtualnyKontrahentum>();

    public virtual ICollection<SlSzybkiePlatnosci> SlSzybkiePlatnoscis { get; set; } = new List<SlSzybkiePlatnosci>();

    public virtual ICollection<TwTowar> TwTowarTwIdPodstDostawcaNavigations { get; set; } = new List<TwTowar>();

    public virtual ICollection<TwTowar> TwTowarTwIdProducentaNavigations { get; set; } = new List<TwTowar>();

    public virtual ICollection<VatEwidVat> VatEwidVats { get; set; } = new List<VatEwidVat>();

    public virtual ICollection<ZlpZlecenie> ZlpZlecenies { get; set; } = new List<ZlpZlecenie>();

    public virtual ICollection<ZpkKsiega> ZpkKsiegas { get; set; } = new List<ZpkKsiega>();
}
