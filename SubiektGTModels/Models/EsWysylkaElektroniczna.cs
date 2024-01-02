using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EsWysylkaElektroniczna
{
    public int SfwId { get; set; }

    public int SfwIdNaglowka { get; set; }

    public byte[]? SfwXmlpodpisany { get; set; }

    public string SfwNrReferencyjny { get; set; } = null!;

    public DateTime? SfwWyslanyData { get; set; }

    public byte[]? SfwUpo { get; set; }

    public DateTime? SfwUpoData { get; set; }

    public int? SfwUpoZrodlo { get; set; }

    public int SfwStatus { get; set; }

    public byte[]? SfwPaczkaZip { get; set; }

    public virtual ICollection<EsWysylkaElektronicznaLog> EsWysylkaElektronicznaLogs { get; set; } = new List<EsWysylkaElektronicznaLog>();

    public virtual EsSprawozdanieFinNaglowek SfwIdNaglowkaNavigation { get; set; } = null!;
}
