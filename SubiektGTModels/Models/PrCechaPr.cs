using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrCechaPr
{
    public int CpId { get; set; }

    public int CpIdPrac { get; set; }

    public int CpIdCecha { get; set; }

    public virtual SlCechaPr CpIdCechaNavigation { get; set; } = null!;

    public virtual PrPracownik CpIdPracNavigation { get; set; } = null!;
}
