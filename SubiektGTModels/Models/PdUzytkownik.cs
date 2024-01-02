using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdUzytkownik
{
    public int UzId { get; set; }

    public string UzIdentyfikator { get; set; } = null!;

    public string UzNazwisko { get; set; } = null!;

    public string UzImie { get; set; } = null!;

    public string UzLogin { get; set; } = null!;

    public string? UzHaslo { get; set; }

    public bool UzStatus { get; set; }

    public int? UzIdKasy { get; set; }

    public bool UzBlokadaKasy { get; set; }

    public int? UzIdMagazynu { get; set; }

    public int UzProgram { get; set; }

    public bool UzPracaZdalna { get; set; }

    public int? UzIdPracownika { get; set; }

    public int? UzIdKompozycji { get; set; }

    public int? UzIdGrupy { get; set; }

    public string UzEmail { get; set; } = null!;

    public string UzGaduGadu { get; set; } = null!;

    public string UzSkype { get; set; } = null!;

    public int UzRodzajInfoOwierszachListy { get; set; }

    public bool? UzUruchomCentralke { get; set; }

    public string? UzPrefiksOsobisty { get; set; }

    public int? UzLimitStanowisk { get; set; }

    public int UzStatusPrzypomnieniaZmianyVat { get; set; }

    public DateTime? UzDataPonownegoPrzypomnienia { get; set; }

    public int UzKlientEmail { get; set; }

    public string? UzDomena { get; set; }

    public int? UzAlarmyInterwal { get; set; }

    public bool UzLokalizacjaPokazuj { get; set; }

    public string? UzLokalizacja { get; set; }

    public int? UzOstatnieKontoEmail { get; set; }

    public DateTime? UzDataHasla { get; set; }

    public bool UzZmianaHasla { get; set; }

    public int? UzPodnoszenieUprawnienUserId { get; set; }

    public bool UzShowTutorialSms { get; set; }

    public virtual ICollection<ApLog> ApLogs { get; set; } = new List<ApLog>();

    public virtual ICollection<DkrBilansOtwarciaZmiana> DkrBilansOtwarciaZmianas { get; set; } = new List<DkrBilansOtwarciaZmiana>();

    public virtual ICollection<DkrBilansOtwarcium> DkrBilansOtwarciumBoIdKorygujacyNavigations { get; set; } = new List<DkrBilansOtwarcium>();

    public virtual ICollection<DkrBilansOtwarcium> DkrBilansOtwarciumBoIdUzytkownikNavigations { get; set; } = new List<DkrBilansOtwarcium>();

    public virtual ICollection<DkrBilansOtwarcium> DkrBilansOtwarciumBoIdZatwierdzajacyNavigations { get; set; } = new List<DkrBilansOtwarcium>();

    public virtual ICollection<DkrDokument> DkrDokumentDkrDekretowalNavigations { get; set; } = new List<DkrDokument>();

    public virtual ICollection<DkrDokument> DkrDokumentDkrKsiegowalNavigations { get; set; } = new List<DkrDokument>();

    public virtual ICollection<DkrSladRewizyjny> DkrSladRewizyjnies { get; set; } = new List<DkrSladRewizyjny>();

    public virtual ICollection<DokDokBiblioteka> DokDokBibliotekas { get; set; } = new List<DokDokBiblioteka>();

    public virtual ICollection<FlWartosc> FlWartoscs { get; set; } = new List<FlWartosc>();

    public virtual ICollection<HbLogin> HbLogins { get; set; } = new List<HbLogin>();

    public virtual ICollection<HbRaport> HbRaports { get; set; } = new List<HbRaport>();

    public virtual ICollection<ImImportPrzeprowadzony> ImImportPrzeprowadzonies { get; set; } = new List<ImImportPrzeprowadzony>();

    public virtual ICollection<InsSlad> InsSlads { get; set; } = new List<InsSlad>();

    public virtual ICollection<KhDokument> KhDokuments { get; set; } = new List<KhDokument>();

    public virtual ICollection<KhKontrahent> KhKontrahents { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhListum> KhLista { get; set; } = new List<KhListum>();

    public virtual ICollection<KhPracownik> KhPracowniks { get; set; } = new List<KhPracownik>();

    public virtual ICollection<KhRachunkiBankoweHistoriaWeryfikacjiBialaListum> KhRachunkiBankoweHistoriaWeryfikacjiBialaLista { get; set; } = new List<KhRachunkiBankoweHistoriaWeryfikacjiBialaListum>();

    public virtual ICollection<KhVy> KhVies { get; set; } = new List<KhVy>();

    public virtual ICollection<KhWeryfikacjaNip> KhWeryfikacjaNips { get; set; } = new List<KhWeryfikacjaNip>();

    public virtual ICollection<NzFinanse> NzFinanses { get; set; } = new List<NzFinanse>();

    public virtual ICollection<NzRaportKasowy> NzRaportKasowyRkIdUtworzylNavigations { get; set; } = new List<NzRaportKasowy>();

    public virtual ICollection<NzRaportKasowy> NzRaportKasowyRkIdZatwierdzilNavigations { get; set; } = new List<NzRaportKasowy>();

    public virtual ICollection<NzWyciagBankowy> NzWyciagBankowyWbIdUtworzylNavigations { get; set; } = new List<NzWyciagBankowy>();

    public virtual ICollection<NzWyciagBankowy> NzWyciagBankowyWbIdZatwierdzilNavigations { get; set; } = new List<NzWyciagBankowy>();

    public virtual ICollection<PdDokument> PdDokuments { get; set; } = new List<PdDokument>();

    public virtual ICollection<PdOstrzezenium> PdOstrzezenia { get; set; } = new List<PdOstrzezenium>();

    public virtual ICollection<PdRokObrotowy> PdRokObrotowies { get; set; } = new List<PdRokObrotowy>();

    public virtual ICollection<PdUlubione> PdUlubiones { get; set; } = new List<PdUlubione>();

    public virtual PdUzytkMagazyn? PdUzytkMagazyn { get; set; }

    public virtual ICollection<PdUzytkModulHist> PdUzytkModulHists { get; set; } = new List<PdUzytkModulHist>();

    public virtual PdUzytkOkre? PdUzytkOkre { get; set; }

    public virtual PdUzytkParam? PdUzytkParam { get; set; }

    public virtual PdUzytkRok? PdUzytkRok { get; set; }

    public virtual ICollection<PdUzytkownikOddzial> PdUzytkownikOddzials { get; set; } = new List<PdUzytkownikOddzial>();

    public virtual ICollection<PlRachunekDoUmowyCp> PlRachunekDoUmowyCps { get; set; } = new List<PlRachunekDoUmowyCp>();

    public virtual ICollection<PlWyplatum> PlWyplata { get; set; } = new List<PlWyplatum>();

    public virtual ICollection<PlbListaPlac> PlbListaPlacs { get; set; } = new List<PlbListaPlac>();

    public virtual ICollection<PlbRachunekDoUmowyCp> PlbRachunekDoUmowyCps { get; set; } = new List<PlbRachunekDoUmowyCp>();

    public virtual ICollection<PlbWyplatum> PlbWyplatumWypIdOsobyWystNavigations { get; set; } = new List<PlbWyplatum>();

    public virtual ICollection<PlbWyplatum> PlbWyplatumWypKorektaKtoNavigations { get; set; } = new List<PlbWyplatum>();

    public virtual ICollection<PrDokument> PrDokuments { get; set; } = new List<PrDokument>();

    public virtual ICollection<PrGiodo> PrGiodos { get; set; } = new List<PrGiodo>();

    public virtual ICollection<RbRachBankowyPersonel> RbRachBankowyPersonels { get; set; } = new List<RbRachBankowyPersonel>();

    public virtual SkSesja? SkSesja { get; set; }

    public virtual ICollection<SmsMessage> SmsMessageSmsmCreators { get; set; } = new List<SmsMessage>();

    public virtual ICollection<SmsMessage> SmsMessageSmsmModifiers { get; set; } = new List<SmsMessage>();

    public virtual ICollection<SmsMessage> SmsMessageSmsmSubmitters { get; set; } = new List<SmsMessage>();

    public virtual ICollection<TwDokument> TwDokuments { get; set; } = new List<TwDokument>();

    public virtual ICollection<UfTransmisja> UfTransmisjas { get; set; } = new List<UfTransmisja>();

    public virtual ICollection<UfZadanie> UfZadanies { get; set; } = new List<UfZadanie>();

    public virtual SlGrupaUz? UzIdGrupyNavigation { get; set; }

    public virtual DksKasa? UzIdKasyNavigation { get; set; }

    public virtual UiKompozycja? UzIdKompozycjiNavigation { get; set; }

    public virtual SlMagazyn? UzIdMagazynuNavigation { get; set; }

    public virtual PrPracownik? UzIdPracownikaNavigation { get; set; }

    public virtual ICollection<ZsRezerwacja> ZsRezerwacjas { get; set; } = new List<ZsRezerwacja>();

    public virtual ICollection<ZsZasob> ZsZasobs { get; set; } = new List<ZsZasob>();

    public virtual ICollection<ZwZdarzenieWindykacyjne> ZwZdarzenieWindykacyjnes { get; set; } = new List<ZwZdarzenieWindykacyjne>();

    public virtual ICollection<ParEwid> PepIdObiektus { get; set; } = new List<ParEwid>();

    public virtual ICollection<DksKasa> PfIdObiektus { get; set; } = new List<DksKasa>();

    public virtual ICollection<GtTransformacja> PfIdObiektus1 { get; set; } = new List<GtTransformacja>();

    public virtual ICollection<PdProdukt> PfIdObiektus2 { get; set; } = new List<PdProdukt>();

    public virtual ICollection<SlMagazyn> PfIdObiektus3 { get; set; } = new List<SlMagazyn>();

    public virtual ICollection<SlMagazyn> PfIdObiektus4 { get; set; } = new List<SlMagazyn>();

    public virtual ICollection<SlMagazyn> PfIdObiektus5 { get; set; } = new List<SlMagazyn>();

    public virtual ICollection<SlSlownik> PfIdObiektus6 { get; set; } = new List<SlSlownik>();

    public virtual ICollection<WyWzorzec> PfIdObiektus7 { get; set; } = new List<WyWzorzec>();

    public virtual ICollection<ZstEwid> PfIdObiektus8 { get; set; } = new List<ZstEwid>();

    public virtual ICollection<DksKasa> PfIdObiektusNavigation { get; set; } = new List<DksKasa>();

    public virtual ICollection<ParTyp> PtpIdObiektus { get; set; } = new List<ParTyp>();

    public virtual ICollection<RbRachBankowy> RbpIdObiektus { get; set; } = new List<RbRachBankowy>();

    public virtual ICollection<UiModul> UipIdModulus { get; set; } = new List<UiModul>();

    public virtual ICollection<SlRodzajZasobu> ZpfIdObiektus { get; set; } = new List<SlRodzajZasobu>();
}
