using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlPanstwaMiejscaProwadzeniaDzialalnosci
{
    public int PmpdId { get; set; }

    public int PmpdIdPanstwa { get; set; }

    public int? PmpdRodzajIdentyfikacji { get; set; }

    public string? PmpdNumerIdentyfikacji { get; set; }

    public virtual SlPanstwo PmpdIdPanstwaNavigation { get; set; } = null!;
}
