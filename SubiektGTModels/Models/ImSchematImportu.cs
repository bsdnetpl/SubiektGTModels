using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportu
{
    public int SiId { get; set; }

    public string SiNazwa { get; set; } = null!;

    public int SiTypDokZrodlowego { get; set; }

    public int? SiIdKatDokZrodlowego { get; set; }

    public bool SiImportDoVat { get; set; }

    public int? SiIdEwidVat { get; set; }

    public int? SiWydatki { get; set; }

    public int? SiPrzeznaczenie { get; set; }

    public int? SiDataWpisuVat { get; set; }

    public int? SiDataSprzWyst { get; set; }

    public int? SiMiesiacOdliczenia { get; set; }

    public int? SiKategoriaZrVat { get; set; }

    public int? SiIdKategoriiVat { get; set; }

    public bool SiPodlegaKsiegowaniu { get; set; }

    public bool? SiImportDoKpir { get; set; }

    public int? SiKolumna { get; set; }

    public int? SiImportWartosciKpir { get; set; }

    public int? SiDataWpisuKpir { get; set; }

    public int? SiKategoriaZrKpir { get; set; }

    public int? SiIdKategoriiKpir { get; set; }

    public bool? SiImportDoEp { get; set; }

    public int? SiIdStawki { get; set; }

    public int? SiImportWartosciEp { get; set; }

    public int? SiDataWpisuEp { get; set; }

    public int? SiDataUp { get; set; }

    public int? SiKategoriaZrEp { get; set; }

    public int? SiIdKategoriiEp { get; set; }

    public int? SiOpisZr { get; set; }

    public string SiOpis { get; set; } = null!;

    public int? SiUwagiZr { get; set; }

    public string SiUwagi { get; set; } = null!;

    public bool SiDowolnaKategoria { get; set; }

    public int SiTypTransakcji { get; set; }

    public int? SiIdKategoriiKh { get; set; }

    public int? SiIdDataOperacji { get; set; }

    public int? SiIdDataDokumentu { get; set; }

    public int? SiIdDataDekretacji { get; set; }

    public int? SiIdRejestruKs { get; set; }

    public bool? SiImportDoKh { get; set; }

    public int? SiTypDokImport { get; set; }

    public bool SiZablokowany { get; set; }

    public int SiKategoriaKhzrodlo { get; set; }

    public int SiTransakcjaVatzrodlo { get; set; }

    public int SiIdTransakcjaVat { get; set; }

    public int? SiIdEwidVatdokZrodlowego { get; set; }

    public int? SiTransakcjaVatdokZrodlowego { get; set; }

    public int? SiIdMagazynu { get; set; }

    public string? SiEwidVatopisUzytk { get; set; }

    public int? SiEwidVatopisIdSlownikOpisow { get; set; }

    public int? SiDokumZrodloUwag { get; set; }

    public string? SiDokumTekst { get; set; }

    public int? SiDokumIdOpisu { get; set; }

    public int? SiTypSt { get; set; }

    public int? SiPrzypSzczegolny { get; set; }

    public int? SiIdKasy { get; set; }

    public int? SiIdRachunku { get; set; }

    public int SiKontrolaBilansowania { get; set; }

    public int? SiEwidVatopisIdTresciOperacji { get; set; }

    public int? SiDokumIdTresciOperacji { get; set; }

    public bool? SiImportDoDw { get; set; }

    public int? SiImportWartosciDw { get; set; }

    public int? SiDataWpisuDw { get; set; }

    public int? SiKategoriaZrDw { get; set; }

    public int? SiIdKategoriiDw { get; set; }

    public int? SiIdDefiniowalnegoTypu { get; set; }

    public bool? SiTypTranVatRozlUsl { get; set; }

    public bool SiImportujPozycje { get; set; }

    public int? SiDataZdarzeniaGospodarczego { get; set; }

    public bool SiPromocje { get; set; }

    public int SiFakturaRr { get; set; }

    public int SiVatmarza { get; set; }

    public bool? SiVatmarzaZak { get; set; }

    public int? SiTypTransakcjiZak { get; set; }

    public int? SiIdEwidVatzak { get; set; }

    public int? SiWydatkiZak { get; set; }

    public int? SiPrzeznaczenieZak { get; set; }

    public int? SiDataZakDost { get; set; }

    public int SiRozliczenieVat { get; set; }

    public int SiRodzajZwrotuDetal { get; set; }

    public bool SiVatoo { get; set; }

    public int? SiIdEwidVatoo { get; set; }

    public int? SiDokumentZrodlowy { get; set; }

    public bool? SiImportDoZpiK { get; set; }

    public int? SiIdDataWpisuZpiK { get; set; }

    public int? SiIdDataZdarzeniaGospZpiK { get; set; }

    public int SiKategoriaZpiKzrodlo { get; set; }

    public int? SiIdKategoriiZpiK { get; set; }

    public int? SiCelZakupu { get; set; }

    public int? SiDekOpisZr { get; set; }

    public string? SiDekOpisUzytk { get; set; }

    public int? SiDekOpisIdSlownikOpisow { get; set; }

    public int? SiDekOpisIdTresciOperacji { get; set; }

    public int SiRodzajDowoduZrodlo { get; set; }

    public int? SiIdRodzajuDowodu { get; set; }

    public bool SiUsunMnemonik { get; set; }

    public int SiStatusFiskalny { get; set; }

    public int SiNabywca { get; set; }

    public int SiPrzypadekSzczegolnyPit { get; set; }

    public int SiOznaczenieDowoduJpkVat { get; set; }

    public bool SiImportDoVatoss { get; set; }

    public int? SiIdEwidVatoss { get; set; }

    public int? SiDataWpisuVatoss { get; set; }

    public int? SiDataZakDostVatoss { get; set; }

    public int? SiMiesiacNaliczeniaVatoss { get; set; }

    public int SiKategoriaZrVatoss { get; set; }

    public int? SiIdKategoriiVatoss { get; set; }

    public int? SiIdEwidVatossdokZrodlowego { get; set; }

    public bool SiKorektaWczesniejszegoKwartalu { get; set; }

    public int? SiKorygowanyKwartal { get; set; }

    public int? SiDataWystawienia { get; set; }

    public int? SiDataMagazynowaOtrzymania { get; set; }

    public int? SiIdTransakcjaVatOss { get; set; }

    public int SiRodzaj { get; set; }

    public bool? SiCzyPobracProceduryJpkzewidencjiVat { get; set; }

    public bool? SiCzyPobracGtuzewidencjiVat { get; set; }

    public bool? SiKryteriumDodatkowe { get; set; }

    public int? SiRodzajKryteriumDodatkowego { get; set; }

    public virtual ICollection<DpDokument> DpDokuments { get; set; } = new List<DpDokument>();

    public virtual ICollection<ImSchematImportuCechaKontrahentum> ImSchematImportuCechaKontrahenta { get; set; } = new List<ImSchematImportuCechaKontrahentum>();

    public virtual ICollection<ImSchematImportuGrupaKontrahentum> ImSchematImportuGrupaKontrahenta { get; set; } = new List<ImSchematImportuGrupaKontrahentum>();

    public virtual ICollection<ImSchematImportuKategorium> ImSchematImportuKategoria { get; set; } = new List<ImSchematImportuKategorium>();

    public virtual ICollection<ImSchematImportuKontrahent> ImSchematImportuKontrahents { get; set; } = new List<ImSchematImportuKontrahent>();

    public virtual ICollection<ImSchematImportuKwotyUzytkownika> ImSchematImportuKwotyUzytkownikas { get; set; } = new List<ImSchematImportuKwotyUzytkownika>();

    public virtual ICollection<ImSchematImportuOpisy> ImSchematImportuOpisies { get; set; } = new List<ImSchematImportuOpisy>();

    public virtual ICollection<ImSchematImportuOznaczeniaJpkVat> ImSchematImportuOznaczeniaJpkVats { get; set; } = new List<ImSchematImportuOznaczeniaJpkVat>();

    public virtual ICollection<ImSchematImportuPozDekretu> ImSchematImportuPozDekretus { get; set; } = new List<ImSchematImportuPozDekretu>();

    public virtual ICollection<ImSchematImportuPozycjaRach> ImSchematImportuPozycjaRaches { get; set; } = new List<ImSchematImportuPozycjaRach>();

    public virtual ICollection<ImSchematImportuRodzajFaktury> ImSchematImportuRodzajFakturies { get; set; } = new List<ImSchematImportuRodzajFaktury>();

    public virtual ICollection<ImSchematImportuTypTransakcji> ImSchematImportuTypTransakcjis { get; set; } = new List<ImSchematImportuTypTransakcji>();

    public virtual ICollection<ImSchematImportuZpiK> ImSchematImportuZpiKs { get; set; } = new List<ImSchematImportuZpiK>();

    public virtual ICollection<PbDokument> PbDokuments { get; set; } = new List<PbDokument>();

    public virtual SlTresc? SiDokumIdTresciOperacjiNavigation { get; set; }

    public virtual SlTresc? SiEwidVatopisIdTresciOperacjiNavigation { get; set; }

    public virtual DokDokumentDefiniowalny? SiIdDefiniowalnegoTypuNavigation { get; set; }

    public virtual SlTypEwidVat? SiIdEwidVatNavigation { get; set; }

    public virtual SlTypEwidVat? SiIdEwidVatdokZrodlowegoNavigation { get; set; }

    public virtual SlTypEwidVat? SiIdEwidVatooNavigation { get; set; }

    public virtual SlEwidVatOss? SiIdEwidVatossdokZrodlowegoNavigation { get; set; }

    public virtual SlTypEwidVat? SiIdEwidVatzakNavigation { get; set; }

    public virtual SlKategorium? SiIdKategoriiKhNavigation { get; set; }

    public virtual SlMagazyn? SiIdMagazynuNavigation { get; set; }

    public virtual SlRejestrKsiegowy? SiIdRejestruKsNavigation { get; set; }

    public virtual SlRodzajDowoduKsiegowego? SiIdRodzajuDowoduNavigation { get; set; }
}
