using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklEDekl
{
    public int DelId { get; set; }

    public int DelIdDeklaracji { get; set; }

    public byte[]? DelXmlwygen { get; set; }

    public DateTime? DelXmlwygenData { get; set; }

    public int? DelXmlwygenZrodlo { get; set; }

    public DateTime? DelXmlexportData { get; set; }

    public byte[]? DelXmlpodpisany { get; set; }

    public DateTime? DelXmlpodpisanyData { get; set; }

    public int? DelXmlpodpisanyZrodlo { get; set; }

    public DateTime? DelXmlwyslanyData { get; set; }

    public int? DelXmlwyslanyStatus { get; set; }

    public string? DelNrReferencyjny { get; set; }

    public byte[]? DelXmlupo { get; set; }

    public DateTime? DelXmlupoData { get; set; }

    public int? DelXmlupoZrodlo { get; set; }

    public int? DelXmlupoStatus { get; set; }

    public int DelStatus { get; set; }

    public bool? DelXmlpodpisanyDaneAutoryzujace { get; set; }

    public virtual ICollection<DeklEDeklLog> DeklEDeklLogs { get; set; } = new List<DeklEDeklLog>();

    public virtual DeklEwid DelIdDeklaracjiNavigation { get; set; } = null!;
}
