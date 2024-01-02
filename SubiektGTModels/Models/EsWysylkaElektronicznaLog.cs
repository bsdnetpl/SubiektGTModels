using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EsWysylkaElektronicznaLog
{
    public int SfwlId { get; set; }

    public int SfwlIdWysylki { get; set; }

    public DateTime SfwlData { get; set; }

    public string SfwlOpis { get; set; } = null!;

    public virtual EsWysylkaElektroniczna SfwlIdWysylkiNavigation { get; set; } = null!;
}
