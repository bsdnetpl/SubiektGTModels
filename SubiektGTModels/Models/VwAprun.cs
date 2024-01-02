using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwAprun
{
    public int ApId { get; set; }

    public string ApNazwa { get; set; } = null!;

    public DateTime? AlDataUruchomienia { get; set; }

    public DateTime? AlOkresOd { get; set; }

    public DateTime? AlOkresDo { get; set; }
}
