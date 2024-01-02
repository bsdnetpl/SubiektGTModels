using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrDokument
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

    public int? DkrIdObiektuVatOss { get; set; }

    public string? DkrNumerKseF { get; set; }

    public virtual PdUzytkownik DkrDekretowalNavigation { get; set; } = null!;

    public virtual ICollection<DkrDokImportowany> DkrDokImportowanies { get; set; } = new List<DkrDokImportowany>();

    public virtual SlWalutaBank? DkrIdBankuNavigation { get; set; }

    public virtual SlKategorium? DkrIdKategoriiNavigation { get; set; }

    public virtual KhKontrahent? DkrIdKhNavigation { get; set; }

    public virtual PdRokObrotowy DkrIdRokuNavigation { get; set; } = null!;

    public virtual PdUzytkownik? DkrKsiegowalNavigation { get; set; }

    public virtual ICollection<DkrPozycja> DkrPozycjas { get; set; } = new List<DkrPozycja>();

    public virtual SlRejestrKsiegowy DkrRejestrNavigation { get; set; } = null!;

    public virtual SlRodzajDowoduKsiegowego? DkrRodzajDowoduNavigation { get; set; }

    public virtual SlWalutum DkrWalutaNavigation { get; set; } = null!;
}
