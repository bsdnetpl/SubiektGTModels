using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKodPrzyczynyWyrejestrowanium
{
    public int KpwId { get; set; }

    public string KpwKod { get; set; } = null!;

    public string KpwOpis { get; set; } = null!;
}
