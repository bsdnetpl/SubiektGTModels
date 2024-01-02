using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwRewSchematyImportuUepiK
{
    public int SiId { get; set; }

    public string SiNazwa { get; set; } = null!;

    public bool SiImportDoVat { get; set; }

    public bool? SiImportDoKpir { get; set; }

    public bool? SiImportDoEp { get; set; }

    public string? NazwaTypu { get; set; }

    public int? SiIdKatDokZrodlowego { get; set; }

    public bool SiDowolnaKategoria { get; set; }

    public string? NazwaTransakcji { get; set; }

    public int SiTypTransakcji { get; set; }

    public int? SiIdRejestruKs { get; set; }

    public int? SiIdKategoriiKh { get; set; }

    public int? SiIdKategoriiVat { get; set; }

    public int? SiIdKategoriiZpiK { get; set; }

    public bool SiZablokowany { get; set; }

    public int? SiTypDokImport { get; set; }

    public string SiIdDataDekretacji { get; set; } = null!;

    public string SiIdDataDokumentu { get; set; } = null!;

    public string SiIdDataOperacji { get; set; } = null!;

    public string SiDataWpisuVat { get; set; } = null!;

    public string SiDataSprzWyst { get; set; } = null!;

    public string SiIdDataWpisuZpiK { get; set; } = null!;

    public string SiIdDataZdarzeniaGospZpiK { get; set; } = null!;

    public int? SiMiesiacOdliczenia { get; set; }

    public int SiTypDokZrodlowego { get; set; }

    public string? NazwaGrupyDok { get; set; }

    public int? Wydatki { get; set; }

    public int? Przeznaczenie { get; set; }

    public int? SiDataZakDost { get; set; }

    public int SiRozliczenieVat { get; set; }

    public string? MagSymbol { get; set; }

    public int SiRodzaj { get; set; }

    public bool? SiKryteriumDodatkowe { get; set; }

    public int? SiRodzajKryteriumDodatkowego { get; set; }
}
