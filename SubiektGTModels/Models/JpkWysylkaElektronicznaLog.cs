using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class JpkWysylkaElektronicznaLog
{
    public int JpkelId { get; set; }

    public int JpkelIdWyslane { get; set; }

    public DateTime JpkelDataWpis { get; set; }

    public string JpkelWpis { get; set; } = null!;

    public virtual JpkWysylkaElektroniczna JpkelIdWyslaneNavigation { get; set; } = null!;
}
