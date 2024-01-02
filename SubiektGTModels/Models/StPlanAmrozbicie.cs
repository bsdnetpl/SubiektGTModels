using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class StPlanAmrozbicie
{
    public int StpsId { get; set; }

    public int StpsIdPlanuAm { get; set; }

    public int StpsMiesiac { get; set; }

    public int StpsLicznik { get; set; }

    public int StpsMianownik { get; set; }

    public int? StpsBilans { get; set; }

    public virtual StPlanAmrok StpsIdPlanuAmNavigation { get; set; } = null!;
}
