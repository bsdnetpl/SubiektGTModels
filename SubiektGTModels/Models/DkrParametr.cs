using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrParametr
{
    public int DkrpId { get; set; }

    public int DkrpDomyslnyTermPlat { get; set; }

    public int DkrpAutoDodawanieRozr { get; set; }

    public bool DkrpAutoNrTransakcji { get; set; }

    public int DkrpSposobAutoRozliczRozr { get; set; }

    public int DkrpKontrolaKreguKosztow { get; set; }

    public bool DkrpWyswietlajDymki { get; set; }

    public bool DkrpPrzepisywanieRejestru { get; set; }

    public bool DkrpPrzepisywanieDtDekretacji { get; set; }

    public bool DkrpPrzepisywanieDtDokumentu { get; set; }

    public bool DkrpPrzepisywanieDtOperacji { get; set; }

    public bool DkrpPrzepisywanieKategorii { get; set; }

    public bool DkrpPrzepisywanieKb { get; set; }

    public bool DkrpPrzepisywanieTo { get; set; }

    public bool DkrpPrzepisywanieWaluty { get; set; }

    public bool DkrpKontrolaUniqNrDokumentu { get; set; }

    public bool DkrpUstawDaneKhWvat { get; set; }

    public int? DkrpParamEwidId { get; set; }

    public bool DkrpKopiujTytulem { get; set; }

    public bool DkrpDekretyZerowe { get; set; }

    public bool DkrpPowielanieRaportRozr { get; set; }

    public bool DkrpPrzepisywanieStorna { get; set; }

    public int DkprSprzedazDataOtrzymania { get; set; }

    public int DkprSprzedazDataWystawienia { get; set; }

    public int DkprSprzedazDataZakDost { get; set; }

    public int DkprZakupDataOtrzymania { get; set; }

    public int DkprZakupDataWystawienia { get; set; }

    public int DkprZakupDataZakDost { get; set; }

    public bool DkrpPrzepisywanieRodzajuDowodu { get; set; }

    public bool DkrpPrzepisywanieOpisu { get; set; }

    public int DkprOssDataWystawienia { get; set; }

    public int DkprOssDataZakDost { get; set; }

    public virtual ParEwid? DkrpParamEwid { get; set; }
}
