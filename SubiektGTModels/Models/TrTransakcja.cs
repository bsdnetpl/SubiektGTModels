using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TrTransakcja
{
    public int TrId { get; set; }

    public int TrIdTransakcji { get; set; }

    public string TrNazwa { get; set; } = null!;

    public int TrKlient { get; set; }

    public int TrStan { get; set; }

    public int TrStatus { get; set; }

    public string? TrStatusOpis { get; set; }

    public int TrScenariusz { get; set; }

    public int TrEtap { get; set; }

    public int? TrPozyskana { get; set; }

    public DateTime TrDataOtwarcia { get; set; }

    public DateTime? TrPlanowanaDataZamkniecia { get; set; }

    public DateTime TrDataUtworzenia { get; set; }

    public int TrUtworzyl { get; set; }

    public DateTime? TrDataModyfikacji { get; set; }

    public int? TrZmodyfikowal { get; set; }

    public DateTime? TrDataZamkniecia { get; set; }

    public int? TrZamknal { get; set; }

    public int TrMaObsluzyc { get; set; }

    public int? TrMaObsluzycOdKlienta { get; set; }

    public int? TrOferta { get; set; }

    public decimal? TrWartoscNetto { get; set; }

    public decimal? TrWartoscBrutto { get; set; }

    public decimal? TrWartoscVat { get; set; }

    public string? TrWaluta { get; set; }

    public int? TrDokZamowienie { get; set; }

    public int? TrDokKoncowy { get; set; }

    public int? TrDokZamowienieId { get; set; }

    public int? TrDokKoncowyId { get; set; }

    public string? TrDokZamowienieSymbol { get; set; }

    public string? TrDokKoncowySymbol { get; set; }

    public int? TrGrupa { get; set; }

    public int? TrDlaczegoNieudana { get; set; }

    public bool? TrWartoscRecznie { get; set; }

    public decimal? TrWalutaKurs { get; set; }

    public string? TrWarunkiDostawy { get; set; }

    public string? TrWarunkiPlatnosci { get; set; }

    public string? TrUwagiDok { get; set; }

    public string? TrDataRealizacji { get; set; }

    public bool? TrPokazujWkal { get; set; }

    public string? TrKolor { get; set; }

    public int? TrPlanowanaGodzinaZamkniecia { get; set; }

    public int? TrZlecenieId { get; set; }
}
