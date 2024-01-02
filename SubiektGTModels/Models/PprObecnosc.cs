using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PprObecnosc
{
    public int PproId { get; set; }

    public int PproIdWpisu { get; set; }

    public int? PproIdAtrybutGodziny { get; set; }

    public virtual SlAtrybutGodzinowy? PproIdAtrybutGodzinyNavigation { get; set; }

    public virtual PprPlanPracy PproIdWpisuNavigation { get; set; } = null!;
}
