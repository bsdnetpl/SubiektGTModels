using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PojKosztyEksploatacjiWpi
{
    public int PojkwId { get; set; }

    public int PojkwIdKosztyEksploatacji { get; set; }

    public int PojkwIdPojazdu { get; set; }

    public decimal PojkwRachunkiMc { get; set; }

    public decimal PojkwRachunkiRos { get; set; }

    public decimal PojkwPrzejazdyMc { get; set; }

    public decimal PojkwPrzejazdyRos { get; set; }

    public decimal PojkwDoKsiegowania { get; set; }

    public decimal PojkwDoKsiegowaniaRos { get; set; }

    public virtual PojKosztyEksploatacji PojkwIdKosztyEksploatacjiNavigation { get; set; } = null!;

    public virtual PojPojazd PojkwIdPojazduNavigation { get; set; } = null!;
}
