using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class StPlanAmrok
{
    public int StpId { get; set; }

    public int StpIdSrodka { get; set; }

    public int StpRok { get; set; }

    public bool StpOk { get; set; }

    public virtual ICollection<StPlanAmrozbicie> StPlanAmrozbicies { get; set; } = new List<StPlanAmrozbicie>();

    public virtual StSrodekTrwaly StpIdSrodkaNavigation { get; set; } = null!;
}
