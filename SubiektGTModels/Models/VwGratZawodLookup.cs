using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratZawodLookup
{
    public int ZwId { get; set; }

    public string ZwKod { get; set; } = null!;

    public string ZwOpis { get; set; } = null!;

    public int? ZwWersja { get; set; }

    public int ZwUzywane { get; set; }
}
