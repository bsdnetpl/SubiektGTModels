using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseDekretyKompensat
{
    public int DkrId { get; set; }

    public int DkrIdRoku { get; set; }

    public DateTime DkrDataDekretacji { get; set; }

    public DateTime DkrDataDokumentu { get; set; }

    public DateTime DkrDataOperacji { get; set; }

    public int DkrStatus { get; set; }

    public string DkrRejestr { get; set; } = null!;

    public int DkrNumer { get; set; }

    public string DkrNrPelny { get; set; } = null!;

    public string DkrDokumentZrodlowy { get; set; } = null!;

    public int DkrKontrolaBilansowania { get; set; }

    public string DkrWaluta { get; set; } = null!;

    public string DkrWalutaWyswietlana { get; set; } = null!;

    public decimal DkrKursDokumentu { get; set; }

    public int DkrLiczbaJednostek { get; set; }

    public int? DkrRodzajKursu { get; set; }

    public DateTime? DkrDataKursu { get; set; }

    public int? DkrIdBanku { get; set; }

    public decimal DkrKwota { get; set; }

    public decimal DkrKwotaWaluta { get; set; }

    public string DkrUwagi { get; set; } = null!;

    public int? DkrIdKategorii { get; set; }

    public string DkrDekretowal { get; set; } = null!;

    public string? DkrKsiegowal { get; set; }

    public int DkrTypObiektu { get; set; }

    public int? DkrIdObiektu { get; set; }

    public int? DkrTypDokImport { get; set; }

    public int? DkrIdDokImport { get; set; }

    public int DkrImportPochodzenie { get; set; }

    public int? DkrIdKh { get; set; }

    public string DkrSymbolKh { get; set; } = null!;

    public int? DkrNrWdzienniku { get; set; }

    public int DkrPodtyp { get; set; }

    public int DkrTrybWprowadzaniaRozrachunkow { get; set; }

    public string DkrWalutaKursWyswietlany { get; set; } = null!;

    public decimal DkrKwotaWn { get; set; }

    public decimal DkrKwotaMa { get; set; }

    public decimal DkrKwotaWalutaWn { get; set; }

    public decimal DkrKwotaWalutaMa { get; set; }

    public int DkrStorno { get; set; }

    public string DkrOpis { get; set; } = null!;

    public int? DkrRodzajDowodu { get; set; }
}
