using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatParametr
{
    public int VatpId { get; set; }

    public int VatpKolumnaKsZao { get; set; }

    public int VatpKolumnaKsKoszt { get; set; }

    public int VatpKsWyborKolumn { get; set; }

    public bool VatpGenTransNabycia { get; set; }

    public int VatpIdEwidVatspNabycia { get; set; }

    public bool VatpAktTransNabycia { get; set; }

    public bool VatpGenTransImport { get; set; }

    public int VatpIdEwidVatspImport { get; set; }

    public bool VatpAktTransImport { get; set; }

    public bool VatpPrzepisywanieEwidVat { get; set; }

    public bool VatpPrzepisywanieDtWpisu { get; set; }

    public bool VatpPrzepisywanieMov { get; set; }

    public bool VatpPrzepisywanieKategorii { get; set; }

    public bool VatpPrzepisywanieTransakcjiVat { get; set; }

    public bool VatpPrzepisywanieOpisu { get; set; }

    public bool VatpPrzepisywanieKh { get; set; }

    public bool VatpPrzepisywanieSo { get; set; }

    public bool VatpKontrolaUniqNrDokumentu { get; set; }

    public bool VatpPrzepisywanieDtSpWyst { get; set; }

    public bool VatpPrzepisywanieTp { get; set; }

    public int VatpEwidSpSortowanie { get; set; }

    public int VatpEwidZakSortowanie { get; set; }

    public bool VatpPrzeliczajDokImportowane { get; set; }

    public int VatpKursRodzaj { get; set; }

    public int VatpKursRodzajDaty { get; set; }

    public int VatpKursIdBanku { get; set; }

    public bool VatpKursPobierajOstatni { get; set; }

    public int? VatpParamEwidId { get; set; }

    public bool VatpGenTransOo { get; set; }

    public int VatpIdEwidVatspOo { get; set; }

    public bool VatpAktTransOo { get; set; }

    public bool VatpPrzepisywanieDtZakDost { get; set; }

    public bool VatpPrzepisywanieKorektyVat { get; set; }

    public bool VatpVatuzupelnianieDblClck { get; set; }

    public bool VatpSpKorygowanieVat { get; set; }

    public bool VatpZakKorygowanieVat { get; set; }

    public bool VatpPrzepisywanieVatMk { get; set; }

    public bool VatpPrzepisywanieDatyZaplaty { get; set; }

    public bool VatpKorektaZakupuTylkoVat { get; set; }

    public bool VatpBlokujVatInnyOkresZamkniety { get; set; }

    public bool VatpVatNpo { get; set; }

    public bool VatpNetto50 { get; set; }

    public bool VatpGenTransItpu { get; set; }

    public int VatpIdEwidVatspItpu { get; set; }

    public bool VatpAktTransItpu { get; set; }

    public int VatpEwidSpSortWydruk { get; set; }

    public int VatpEwidZakSortWydruk { get; set; }

    public bool VatpBrakKontrahenta { get; set; }

    public bool VatpVatkorygMsgBox { get; set; }

    public bool VatpPrzenoszenieDatyEwidSp { get; set; }

    public bool VatpPrzenoszenieDatyEwidZak { get; set; }

    public bool VatpPrzypadekSzczegolnyTylkoVat { get; set; }

    public bool VatpProporcjaBazowaTylkoVat { get; set; }

    public bool VatpBlokujVatOkresNieistniejacy { get; set; }

    public bool VatpGenTransOodt { get; set; }

    public int VatpIdEwidVatspOodt { get; set; }

    public bool VatpAktTransOodt { get; set; }

    public bool VatpPrzepisywanieCelZakupu { get; set; }

    public bool VatpGenTransWntst { get; set; }

    public int VatpIdEwidVatspWntst { get; set; }

    public bool VatpAktTransWntst { get; set; }

    public bool VatpGenTransWntps { get; set; }

    public int VatpIdEwidVatspWntps { get; set; }

    public bool VatpAktTransWntps { get; set; }

    public bool VatpPrzepisywaniePrzypadekSzczegolny { get; set; }

    public bool VatpPrzypadekSzczegolnyZaokr { get; set; }

    public int VatpKsDataWpisuZao { get; set; }

    public int VatpKsDataZdGospZao { get; set; }

    public int VatpKsDataWpisuKoszt { get; set; }

    public int VatpKsDataZdGospKoszt { get; set; }

    public bool VatpKsSpWgParam { get; set; }

    public int VatpKsSpKolumna { get; set; }

    public int VatpKsSpDataWpisu { get; set; }

    public int VatpKsSpDataZdGosp { get; set; }

    public bool VatpGenTransImuv { get; set; }

    public int VatpIdEwidVatspImuv { get; set; }

    public bool VatpAktTransImuv { get; set; }

    public int VatpDataWpisuNabycia { get; set; }

    public int VatpDataSznabycia { get; set; }

    public int VatpDataZdnabycia { get; set; }

    public int VatpDataWpisuImport { get; set; }

    public int VatpDataSzimport { get; set; }

    public int VatpDataZdimport { get; set; }

    public int VatpDataWpisuOo { get; set; }

    public int VatpDataSzoo { get; set; }

    public int VatpDataZdoo { get; set; }

    public int VatpDataWpisuItpu { get; set; }

    public int VatpDataSzitpu { get; set; }

    public int VatpDataZditpu { get; set; }

    public int VatpDataWpisuOodt { get; set; }

    public int VatpDataSzoodt { get; set; }

    public int VatpDataZdoodt { get; set; }

    public int VatpDataWpisuWntst { get; set; }

    public int VatpDataSzwntst { get; set; }

    public int VatpDataZdwntst { get; set; }

    public int VatpDataWpisuWntps { get; set; }

    public int VatpDataSzwntps { get; set; }

    public int VatpDataZdwntps { get; set; }

    public int VatpDataWpisuImuv { get; set; }

    public int VatpDataSzimuv { get; set; }

    public int VatpDataZdimuv { get; set; }

    public int VatpPrzypadekSzczegolnyPit { get; set; }

    public bool VatpGenTransTtu { get; set; }

    public int VatpIdEwidVatspTtu { get; set; }

    public bool VatpAktTransTtu { get; set; }

    public int VatpDataWpisuTtu { get; set; }

    public int VatpDataSzttu { get; set; }

    public int VatpDataZdttu { get; set; }

    public bool VatpOznaczenieDowoduJpk { get; set; }

    public bool VatpOznaczeniaProcedurJpk { get; set; }

    public bool VatpOznaczeniaDostawyJpk { get; set; }

    public virtual SlTypEwidVat VatpIdEwidVatspImportNavigation { get; set; } = null!;

    public virtual SlTypEwidVat VatpIdEwidVatspItpuNavigation { get; set; } = null!;

    public virtual SlTypEwidVat VatpIdEwidVatspNabyciaNavigation { get; set; } = null!;

    public virtual SlTypEwidVat VatpIdEwidVatspOoNavigation { get; set; } = null!;

    public virtual SlWalutaBank VatpKursIdBankuNavigation { get; set; } = null!;

    public virtual ParEwid? VatpParamEwid { get; set; }
}
