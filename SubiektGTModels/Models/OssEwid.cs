using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class OssEwid
{
    public int OeId { get; set; }

    public string OeNrDokumentu { get; set; } = null!;

    public int? OeIdKh { get; set; }

    public string OeSymbolKh { get; set; } = null!;

    public string OeNazwaKh { get; set; } = null!;

    public string OeNazwaPelnaKh { get; set; } = null!;

    public string OeUlicaKh { get; set; } = null!;

    public string OeMiastoKh { get; set; } = null!;

    public string OeKodPocztowyKh { get; set; } = null!;

    public string OeOpis { get; set; } = null!;

    public DateTime OeDataWpisu { get; set; }

    public DateTime OeDataZakDostawy { get; set; }

    public DateTime? OeMiesiacOdliczVat { get; set; }

    public int? OeIdTerminPlatnosci { get; set; }

    public DateTime? OeTerminPlatnosci { get; set; }

    public int? OeIdTypuEwidVat { get; set; }

    public int OeTransakcjaVat { get; set; }

    public int? OeIdKategorii { get; set; }

    public int OeIdPanstwaKonsumpcji { get; set; }

    public int OeIdPanstwaRozpWysylki { get; set; }

    public string? OeInfoDodatkowe { get; set; }

    public string OeWalutaDokumentu { get; set; } = null!;

    public string OeWalutaZaliczki { get; set; } = null!;

    public string OeWalutaZaplaty { get; set; } = null!;

    public decimal OeKwotaZaliczki { get; set; }

    public decimal OeKwotaZaplaty { get; set; }

    public DateTime? OeDataZaliczki { get; set; }

    public DateTime? OeDataZaplaty { get; set; }

    public decimal? OeKursDeklaracjaVat { get; set; }

    public decimal? OeKursKsiegowanie { get; set; }

    public int? OeLiczbaJednostekDeklaracjaVat { get; set; }

    public int? OeLiczbaJednostekKsiegowanie { get; set; }

    public int? OeRodzajKursuDeklaracjaVat { get; set; }

    public int? OeRodzajKursuKsiegowanie { get; set; }

    public DateTime? OeDataKursuDeklaracjaVat { get; set; }

    public DateTime? OeDataKursuKsiegowanie { get; set; }

    public int? OeIdBankuDeklaracjaVat { get; set; }

    public int? OeIdBankuKsiegowanie { get; set; }

    public string OeUwagi { get; set; } = null!;

    public string OeNipkh { get; set; } = null!;

    public bool OeAutoPrzeliczajVat { get; set; }

    public bool OeNieWliczanyDoPb { get; set; }

    public decimal OeNettoPln { get; set; }

    public decimal OeVatPln { get; set; }

    public decimal OeBruttoPln { get; set; }

    public decimal OeNettoEur { get; set; }

    public decimal OeVatEur { get; set; }

    public decimal OeBruttoEur { get; set; }

    public int OeTypObiektu { get; set; }

    public int? OeIdObiektu { get; set; }

    public bool OeKsiegowany { get; set; }

    public int OeImportPochodzenie { get; set; }

    public int? OeIdDokImport { get; set; }

    public int? OeTypDokImport { get; set; }

    public bool OeKorekta { get; set; }

    public int? OeKwartalKorekty { get; set; }

    public int? OeRokKorekty { get; set; }

    public virtual SlWalutaBank? OeIdBankuDeklaracjaVatNavigation { get; set; }

    public virtual SlWalutaBank? OeIdBankuKsiegowanieNavigation { get; set; }

    public virtual SlKategorium? OeIdKategoriiNavigation { get; set; }

    public virtual KhKontrahent? OeIdKhNavigation { get; set; }

    public virtual SlPanstwo OeIdPanstwaKonsumpcjiNavigation { get; set; } = null!;

    public virtual SlPanstwo OeIdPanstwaRozpWysylkiNavigation { get; set; } = null!;

    public virtual SlFormaPlatnosci? OeIdTerminPlatnosciNavigation { get; set; }

    public virtual SlEwidVatOss? OeIdTypuEwidVatNavigation { get; set; }

    public virtual ICollection<OssDaneVat> OssDaneVats { get; set; } = new List<OssDaneVat>();

    public virtual ICollection<OssPozycja> OssPozycjas { get; set; } = new List<OssPozycja>();
}
