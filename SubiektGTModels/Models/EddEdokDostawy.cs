using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EddEdokDostawy
{
    public int EddId { get; set; }

    public string? EddXml { get; set; }

    public int? EddIdDokumentu { get; set; }

    public string? EddIdWiadomosci { get; set; }

    public string? EddLokNrRef { get; set; }

    public DateTime? EddDataWyst { get; set; }

    public DateTime? EddDataWysylki { get; set; }

    public int EddStatus { get; set; }

    public string? EddNrDdarc { get; set; }

    public int EddIdMagazynu { get; set; }

    public int EddWersja { get; set; }

    public virtual DokDokument? EddIdDokumentuNavigation { get; set; }

    public virtual SlMagazyn EddIdMagazynuNavigation { get; set; } = null!;
}
