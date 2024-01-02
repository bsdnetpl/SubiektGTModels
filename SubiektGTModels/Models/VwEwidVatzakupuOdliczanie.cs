using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwEwidVatzakupuOdliczanie
{
    public int EvId { get; set; }

    public string EvNrDokumentu { get; set; } = null!;

    public int EvRodzaj { get; set; }

    public int? EvIdKh { get; set; }

    public string EvNazwaKh { get; set; } = null!;

    public string EvNazwaPelnaKh { get; set; } = null!;

    public string EvUlicaKh { get; set; } = null!;

    public string EvMiastoKh { get; set; } = null!;

    public string EvKodPocztowyKh { get; set; } = null!;

    public string EvNipkh { get; set; } = null!;

    public DateTime EvDataWpisu { get; set; }

    public DateTime EvDataSz { get; set; }

    public DateTime? EvMiesiacOdliczVat { get; set; }

    public int? EvIdKategorii { get; set; }

    public string EvOpis { get; set; } = null!;

    public decimal EvNetto { get; set; }

    public decimal EvKwotaVat { get; set; }

    public decimal EvBrutto { get; set; }

    public int? EvIdTypuEwidVat { get; set; }

    public int EvFakturaRr { get; set; }

    public DateTime? EvDataPlatnosciRr { get; set; }

    public string EvUwagi { get; set; } = null!;

    public int? EvRodzajZakupu { get; set; }

    public int? EvSposobOdliczania { get; set; }

    public int EvTypObiektu { get; set; }

    public int? EvIdObiektu { get; set; }

    public bool EvKsiegowany { get; set; }

    public bool EvImportowany { get; set; }

    public bool EvKorektaSn { get; set; }

    public int? EvIdDokImport { get; set; }

    public int? EvTypDokImport { get; set; }

    public int EvImportPochodzenie { get; set; }

    public int EvTransakcjaVat { get; set; }

    public int? EvIdDokVat { get; set; }

    public bool EvNieWliczanyDoPb { get; set; }

    public int EvIdOkresuRoku { get; set; }

    public int EvMalyPojazd { get; set; }

    public bool EvPlatnoscKredyt { get; set; }

    public int? EvIdTerminPlatnosci { get; set; }

    public DateTime? EvTerminPlatnosci { get; set; }

    public string EvNrDokumentuSort { get; set; } = null!;

    public bool EvAutoPrzeliczaj { get; set; }

    public bool EvRozliczanaUsluga { get; set; }

    public bool EvDokVatMarza { get; set; }

    public DateTime? EvDataZakDostawy { get; set; }

    public bool EvWlaczKorygowanieVat { get; set; }

    public int EvKorektaVattyp { get; set; }

    public DateTime? EvKorektaVatdataPlatnosci { get; set; }

    public DateTime? EvKorektaVatterminKorekty { get; set; }

    public int? EvKorektaVatidDokKorygowany { get; set; }

    public string? EvKorektaVatnrDokKorygowany { get; set; }

    public bool EvKorektaVatplatnoscCzesciowa { get; set; }

    public DateTime? EvKorektaVatdataWystawieniaDokKorygowany { get; set; }

    public DateTime? EvKorektaVatterminPlatnosciDokKorygowany { get; set; }

    public bool EvVatMetodaKasowa { get; set; }

    public int? EvIdDokVatdod { get; set; }

    public int? EvIdRachunkuZaPrzejazd { get; set; }

    public int EvCelZakupu { get; set; }

    public int EvPodtypDok { get; set; }

    public int EvPrzypadekSzczegolnyPit { get; set; }

    public string? EvNumerKseF { get; set; }

    public decimal? VatOdliczany { get; set; }

    public decimal? VatBezOdliczenia { get; set; }

    public int? EvIdOstatniWpisWeryfikacjiStatusuVat { get; set; }

    public int? EvIdOstatniWpisWeryfikacjiStatusuVies { get; set; }

    public int? EvIdOstatniWpisWeryfikacjiWykazPodatnikowVat { get; set; }

    public decimal? EvWartoscVatmarza { get; set; }
}
