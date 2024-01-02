using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KprKsiega
{
    public int KprId { get; set; }

    public string KprNrDokumentu { get; set; } = null!;

    public DateTime KprDataZdarzenia { get; set; }

    public int KprRodzaj { get; set; }

    public int? KprIdKh { get; set; }

    public string KprNazwaKh { get; set; } = null!;

    public string KprNazwaPelnaKh { get; set; } = null!;

    public string KprUlicaKh { get; set; } = null!;

    public string KprMiastoKh { get; set; } = null!;

    public string KprKodPocztowyKh { get; set; } = null!;

    public string KprNipkh { get; set; } = null!;

    public int? KprIdKategorii { get; set; }

    public string KprOpis { get; set; } = null!;

    public decimal KprKolPrzychSpTowUsl { get; set; }

    public decimal KprKolPrzychPozostale { get; set; }

    public decimal? KprKolPrzychRazem { get; set; }

    public decimal KprKolZakTowarow { get; set; }

    public decimal KprKolZakKosztyUbocz { get; set; }

    public decimal KprKolWydReprRekl { get; set; }

    public decimal KprKolWydWynagr { get; set; }

    public decimal KprKolWydPozostale { get; set; }

    public decimal? KprKolWydRazem { get; set; }

    public decimal KprKolInne { get; set; }

    public string KprKolUwagi { get; set; } = null!;

    public decimal? KprZakupy { get; set; }

    public decimal? KprZakupyWydatki { get; set; }

    public decimal? KprDochod { get; set; }

    public bool KprUniewazniony { get; set; }

    public int KprTypObiektu { get; set; }

    public int? KprIdObiektu { get; set; }

    public bool KprImportowany { get; set; }

    public bool KprKorektaSn { get; set; }

    public int? KprIdDokImport { get; set; }

    public int? KprTypDokImport { get; set; }

    public int KprIdOkresu { get; set; }

    public DateTime KprDataZdarzeniaGospodarczego { get; set; }

    public int KprKorektaKuptyp { get; set; }

    public DateTime? KprKorektaKupterminPlatnosci { get; set; }

    public DateTime? KprKorektaKupdataPlatnosci { get; set; }

    public DateTime? KprKorektaKupterminKorekty { get; set; }

    public int? KprKorektaKupidDokKorygowany { get; set; }

    public bool KprKorektaKupplatnoscCzesciowa { get; set; }

    public string? KprKorektaKupnrDokKorygowany { get; set; }

    public bool KprWlaczKorygowanieKup { get; set; }

    public string? KprKorektaKupdowodZaplaty { get; set; }

    public int KprMalyPojazd { get; set; }

    public int? KprStawkaVat { get; set; }

    public int KprWersjaKpiR { get; set; }

    public decimal KprKolBadaniaRozwoj { get; set; }

    public int? KprTypOpisuKolBadaniaRozwoj { get; set; }

    public string? KprOpisKolBadaniaRozwoj { get; set; }

    public int KprPrzypadekSzczegolnyPit { get; set; }

    public int KprNettoBrutto { get; set; }

    public decimal KprWartoscZfaktury { get; set; }

    public int? KprIdPanstwaKonsumpcji { get; set; }

    public int? KprStawkaVatOss { get; set; }

    public int? KprIdObiektuVatoss { get; set; }

    public string KprSymbolKh { get; set; } = null!;

    public string? KprNumerKseF { get; set; }

    public virtual ICollection<KprKsiega> InverseKprKorektaKupidDokKorygowanyNavigation { get; set; } = new List<KprKsiega>();

    public virtual SlKategorium? KprIdKategoriiNavigation { get; set; }

    public virtual KhKontrahent? KprIdKhNavigation { get; set; }

    public virtual PdOkre KprIdOkresuNavigation { get; set; } = null!;

    public virtual SlPanstwo? KprIdPanstwaKonsumpcjiNavigation { get; set; }

    public virtual KprKsiega? KprKorektaKupidDokKorygowanyNavigation { get; set; }

    public virtual ICollection<RemEwid> RemEwids { get; set; } = new List<RemEwid>();

    public virtual ICollection<RemPozycja> RemPozycjas { get; set; } = new List<RemPozycja>();
}
