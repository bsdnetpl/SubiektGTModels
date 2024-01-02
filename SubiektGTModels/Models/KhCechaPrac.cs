using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhCechaPrac
{
    public int CpId { get; set; }

    public int CpIdPrac { get; set; }

    public int CpIdCecha { get; set; }

    public virtual SlCechaKh CpIdCechaNavigation { get; set; } = null!;

    public virtual KhPracownik CpIdPracNavigation { get; set; } = null!;
}
