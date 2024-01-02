using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwSchematyImportu
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

    public bool SiZablokowany { get; set; }

    public int? SiTypDokImport { get; set; }

    public int? SiWydatki { get; set; }

    public int? SiIdDataDekretacji { get; set; }

    public int? SiIdDataDokumentu { get; set; }

    public int? SiIdDataOperacji { get; set; }

    public int? SiDataWpisuVat { get; set; }

    public int? SiDataSprzWyst { get; set; }

    public int? SiPrzeznaczenie { get; set; }

    public int? SiMiesiacOdliczenia { get; set; }

    public bool? SiImportDoDw { get; set; }

    public int? SiDataZakDost { get; set; }

    public int SiRozliczenieVat { get; set; }

    public int? SiIdDefiniowalnegoTypu { get; set; }

    public int SiTypDokZrodlowego { get; set; }

    public bool SiImportDoVatoss { get; set; }

    public int SiRodzaj { get; set; }

    public bool? SiKryteriumDodatkowe { get; set; }

    public int? SiRodzajKryteriumDodatkowego { get; set; }
}
