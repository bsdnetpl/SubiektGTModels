using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class CenCennikCecha
{
    public int CcId { get; set; }

    public int CcIdSzablon { get; set; }

    public int CcIdCecha { get; set; }

    public virtual SlCechaTw CcIdCechaNavigation { get; set; } = null!;

    public virtual CenCennikSzablon CcIdSzablonNavigation { get; set; } = null!;
}
