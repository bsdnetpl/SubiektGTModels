using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class StSrodekTrwalyPlanAm
{
    public int StaId { get; set; }

    public int StaIdSrodka { get; set; }

    public int StaMiesiac { get; set; }

    public int StaLicznik { get; set; }

    public int StaMianownik { get; set; }

    public bool? StaBilans { get; set; }

    public virtual StSrodekTrwaly StaIdSrodkaNavigation { get; set; } = null!;
}
