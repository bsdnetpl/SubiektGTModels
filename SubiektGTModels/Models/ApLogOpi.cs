using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ApLogOpi
{
    public int AloId { get; set; }

    public int AloIdLogu { get; set; }

    public int AloWynik { get; set; }

    public string? AloOpis { get; set; }

    public virtual ApLog AloIdLoguNavigation { get; set; } = null!;
}
