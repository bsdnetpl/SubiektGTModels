using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKategorium
{
    public int KatId { get; set; }

    public string KatNazwa { get; set; } = null!;

    public int KatTyp { get; set; }

    public string KatPodtytul { get; set; } = null!;

    public virtual ICollection<DfwFakturyWewnetrzne> DfwFakturyWewnetrznes { get; set; } = new List<DfwFakturyWewnetrzne>();

    public virtual ICollection<DkrAutomat> DkrAutomats { get; set; } = new List<DkrAutomat>();

    public virtual ICollection<DkrDokument> DkrDokuments { get; set; } = new List<DkrDokument>();

    public virtual ICollection<DkrWzorzec> DkrWzorzecs { get; set; } = new List<DkrWzorzec>();

    public virtual ICollection<DksKasa> DksKasaKsRkKategoriaKorektyNavigations { get; set; } = new List<DksKasa>();

    public virtual ICollection<DksKasa> DksKasaKsRkKategoriaNavigations { get; set; } = new List<DksKasa>();

    public virtual ICollection<DnkNotaKorygujaca> DnkNotaKorygujacas { get; set; } = new List<DnkNotaKorygujaca>();

    public virtual ICollection<DokDokument> DokDokuments { get; set; } = new List<DokDokument>();

    public virtual ICollection<DpDokument> DpDokuments { get; set; } = new List<DpDokument>();

    public virtual ICollection<DwDokument> DwDokuments { get; set; } = new List<DwDokument>();

    public virtual ICollection<DwParametr> DwParametrs { get; set; } = new List<DwParametr>();

    public virtual ICollection<ImSchematImportuKategorium> ImSchematImportuKategoria { get; set; } = new List<ImSchematImportuKategorium>();

    public virtual ICollection<ImSchematImportuPozDekretu> ImSchematImportuPozDekretus { get; set; } = new List<ImSchematImportuPozDekretu>();

    public virtual ICollection<ImSchematImportu> ImSchematImportus { get; set; } = new List<ImSchematImportu>();

    public virtual ICollection<IwDokument> IwDokuments { get; set; } = new List<IwDokument>();

    public virtual ICollection<KhKategoriaDokumentu> KhKategoriaDokumentus { get; set; } = new List<KhKategoriaDokumentu>();

    public virtual ICollection<KhKontrahent> KhKontrahentKhIdEwVatspKategNavigations { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhKontrahent> KhKontrahentKhIdEwVatzakKategNavigations { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhKontrahent> KhKontrahentKhIdKategoriaKhNavigations { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhKontrahent> KhKontrahentKhIdRachKategPrzychodNavigations { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhKontrahent> KhKontrahentKhIdRachKategRozchodNavigations { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhParametr> KhParametrKhpIdEwVatspKategNavigations { get; set; } = new List<KhParametr>();

    public virtual ICollection<KhParametr> KhParametrKhpIdEwVatzakKategNavigations { get; set; } = new List<KhParametr>();

    public virtual ICollection<KhParametr> KhParametrKhpIdKategoriaKhNavigations { get; set; } = new List<KhParametr>();

    public virtual ICollection<KhParametr> KhParametrKhpIdRachKategPrzychodNavigations { get; set; } = new List<KhParametr>();

    public virtual ICollection<KhParametr> KhParametrKhpIdRachKategRozchodNavigations { get; set; } = new List<KhParametr>();

    public virtual ICollection<KorKorektaKosztow> KorKorektaKosztows { get; set; } = new List<KorKorektaKosztow>();

    public virtual ICollection<KprKsiega> KprKsiegas { get; set; } = new List<KprKsiega>();

    public virtual ICollection<KprParametr> KprParametrKprpIdKategoriiPrzNavigations { get; set; } = new List<KprParametr>();

    public virtual ICollection<KprParametr> KprParametrKprpIdKategoriiSnNavigations { get; set; } = new List<KprParametr>();

    public virtual ICollection<KprParametr> KprParametrKprpIdKategoriiZakNavigations { get; set; } = new List<KprParametr>();

    public virtual ICollection<KsefFakturyKsiegowosc> KsefFakturyKsiegowoscs { get; set; } = new List<KsefFakturyKsiegowosc>();

    public virtual ICollection<MiSprzedazParametr> MiSprzedazParametrMispIdKatDokPrzyjeciaNavigations { get; set; } = new List<MiSprzedazParametr>();

    public virtual ICollection<MiSprzedazParametr> MiSprzedazParametrMispIdKatDokSprzedazyNavigations { get; set; } = new List<MiSprzedazParametr>();

    public virtual ICollection<MkKorektum> MkKorekta { get; set; } = new List<MkKorektum>();

    public virtual ICollection<MkKoszt> MkKoszts { get; set; } = new List<MkKoszt>();

    public virtual ICollection<MkPrzesuniecie> MkPrzesuniecies { get; set; } = new List<MkPrzesuniecie>();

    public virtual ICollection<MkRatum> MkRata { get; set; } = new List<MkRatum>();

    public virtual ICollection<NzFinanseNotum> NzFinanseNota { get; set; } = new List<NzFinanseNotum>();

    public virtual ICollection<NzFinanseSplatum> NzFinanseSplata { get; set; } = new List<NzFinanseSplatum>();

    public virtual ICollection<NzFinanse> NzFinanses { get; set; } = new List<NzFinanse>();

    public virtual ICollection<NzRaportKasowy> NzRaportKasowies { get; set; } = new List<NzRaportKasowy>();

    public virtual ICollection<NzWyciagBankowy> NzWyciagBankowies { get; set; } = new List<NzWyciagBankowy>();

    public virtual ICollection<OssEwid> OssEwids { get; set; } = new List<OssEwid>();

    public virtual ICollection<PbDokument> PbDokuments { get; set; } = new List<PbDokument>();

    public virtual ICollection<PdWspolnikSkladka> PdWspolnikSkladkas { get; set; } = new List<PdWspolnikSkladka>();

    public virtual ICollection<PlListaPlac> PlListaPlacs { get; set; } = new List<PlListaPlac>();

    public virtual ICollection<PlRachunekDoUmowyCp> PlRachunekDoUmowyCps { get; set; } = new List<PlRachunekDoUmowyCp>();

    public virtual ICollection<PlbListaPlac> PlbListaPlacs { get; set; } = new List<PlbListaPlac>();

    public virtual ICollection<PlbRachunekDoUmowyCp> PlbRachunekDoUmowyCps { get; set; } = new List<PlbRachunekDoUmowyCp>();

    public virtual ICollection<PlbUmowaCpParametryZestaw> PlbUmowaCpParametryZestaws { get; set; } = new List<PlbUmowaCpParametryZestaw>();

    public virtual ICollection<PlbUmowaCp> PlbUmowaCps { get; set; } = new List<PlbUmowaCp>();

    public virtual ICollection<PojEksploatacja> PojEksploatacjas { get; set; } = new List<PojEksploatacja>();

    public virtual ICollection<PojKosztyEksploatacji> PojKosztyEksploatacjis { get; set; } = new List<PojKosztyEksploatacji>();

    public virtual ICollection<PojParametr> PojParametrPpRachunekIdKategoriiNavigations { get; set; } = new List<PojParametr>();

    public virtual ICollection<PojParametr> PojParametrPpRachunekIdKategoriiVatNavigations { get; set; } = new List<PojParametr>();

    public virtual ICollection<PrzParametr> PrzParametrPrzpIdKategoriiPrzNavigations { get; set; } = new List<PrzParametr>();

    public virtual ICollection<PrzParametr> PrzParametrPrzpIdKategoriiSnNavigations { get; set; } = new List<PrzParametr>();

    public virtual ICollection<PrzPrzychod> PrzPrzychods { get; set; } = new List<PrzPrzychod>();

    public virtual ICollection<RbRachBankowy> RbRachBankowies { get; set; } = new List<RbRachBankowy>();

    public virtual ICollection<RfRaportyFiskalne> RfRaportyFiskalnes { get; set; } = new List<RfRaportyFiskalne>();

    public virtual ICollection<SlEwidVatOss> SlEwidVatOsses { get; set; } = new List<SlEwidVatOss>();

    public virtual ICollection<SlRejestrKsiegowy> SlRejestrKsiegowies { get; set; } = new List<SlRejestrKsiegowy>();

    public virtual ICollection<SlTypEwidVat> SlTypEwidVats { get; set; } = new List<SlTypEwidVat>();

    public virtual ICollection<VatEwidVat> VatEwidVats { get; set; } = new List<VatEwidVat>();

    public virtual ICollection<ZpkKsiega> ZpkKsiegas { get; set; } = new List<ZpkKsiega>();
}
