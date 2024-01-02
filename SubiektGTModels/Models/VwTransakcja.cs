using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwTransakcja
{
    public int TrId { get; set; }

    public int? TrOferta { get; set; }

    public int TrStan { get; set; }

    public int TrStatus { get; set; }

    public string? TrStatusOpis { get; set; }

    public string TrNazwa { get; set; } = null!;

    public string? KhNazwa { get; set; }

    public int? TrcId { get; set; }

    public string? TrcNazwa { get; set; }

    public int? TrdId { get; set; }

    public string? TrdNazwa { get; set; }

    public int? TrdProcentSukcesu { get; set; }

    public DateTime TrDataOtwarcia { get; set; }

    public DateTime? TrPlanowanaDataZamkniecia { get; set; }

    public DateTime? TrDataZamkniecia { get; set; }

    public string? TreNazwa { get; set; }

    public DateTime? TrDataModyfikacji { get; set; }

    public string? UzZmodyfikowal { get; set; }

    public string? UzNazwa { get; set; }

    public int TrMaObsluzyc { get; set; }

    public string? UzNazwaOdKl { get; set; }

    public int? TrMaObsluzycOdKlienta { get; set; }

    public string? UzMailOdKl { get; set; }

    public string? UzGaduOdKl { get; set; }

    public string? UzSkypeOdKl { get; set; }

    public string? UzTelefonOdKl { get; set; }

    public int TrKlient { get; set; }

    public string? TrWaluta { get; set; }

    public decimal? TrWartoscNetto { get; set; }

    public decimal? TrWartoscVat { get; set; }

    public decimal? TrWartoscBrutto { get; set; }

    public string? TrgNazwa { get; set; }

    public int? TrgId { get; set; }

    public string? TrWartoscNettoW { get; set; }

    public string? TrWartoscVatW { get; set; }

    public string? TrWartoscBruttoW { get; set; }

    public decimal? TrWartoscNettoP { get; set; }

    public decimal? TrWartoscVatP { get; set; }

    public decimal? TrWartoscBruttoP { get; set; }

    public string TrZamowienie { get; set; } = null!;

    public string TrKoncowy { get; set; } = null!;

    public string? TrDokZamowienieSymbol { get; set; }

    public string? TrDokKoncowySymbol { get; set; }

    public string? DokNrPelny { get; set; }

    public int? TrDokZamowienieId { get; set; }

    public int? TrDokKoncowyId { get; set; }

    public int? TrDokZamowienie { get; set; }

    public int? TrDokKoncowy { get; set; }

    public decimal? DokWartNetto { get; set; }

    public decimal? DokWartVat { get; set; }

    public decimal? DokWartBrutto { get; set; }

    public int? TrDniSpoznienia { get; set; }

    public bool? TrWartoscRecznie { get; set; }

    public int? DokNr { get; set; }

    public string? TrnNazwa { get; set; }

    public int TrEtap { get; set; }

    public string? TrPrzygotowal { get; set; }

    public string? TrUwagiDok { get; set; }

    public string? TrWarunkiDostawy { get; set; }

    public string? TrWarunkiPlatnosci { get; set; }

    public string? TrDataRealizacji { get; set; }

    public int? TrPozostaloDni { get; set; }

    public bool? TrPokazujWkal { get; set; }

    public string? TrKolor { get; set; }

    public DateTime TrDataUtworzenia { get; set; }

    public string? GodzinaZamknieciaStr { get; set; }

    public int? TrPlanowanaGodzinaZamkniecia { get; set; }

    public string? AdrSymbol { get; set; }

    public string? AdrNazwaPelna { get; set; }
}
