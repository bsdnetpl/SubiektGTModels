using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class JpkWysylkaElektroniczna
{
    public int JpkeId { get; set; }

    public int JpkeIdPaczki { get; set; }

    public string? JpkeNrReferencyjny { get; set; }

    public DateTime? JpkeWyslanyData { get; set; }

    public byte[]? JpkeUpo { get; set; }

    public DateTime? JpkeUpoData { get; set; }

    public int? JpkeUpoZrodlo { get; set; }

    public int? JpkeStatus { get; set; }

    public bool JpkeDaneAutoryzujace { get; set; }

    public virtual ICollection<JpkWysylkaElektronicznaLog> JpkWysylkaElektronicznaLogs { get; set; } = new List<JpkWysylkaElektronicznaLog>();

    public virtual JpkPaczka JpkeIdPaczkiNavigation { get; set; } = null!;
}
