using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZsCechaZ
{
    public int CzId { get; set; }

    public int CzIdZs { get; set; }

    public int CzIdCecha { get; set; }

    public virtual SlCechaZ CzIdCechaNavigation { get; set; } = null!;

    public virtual ZsZasob CzIdZsNavigation { get; set; } = null!;
}
