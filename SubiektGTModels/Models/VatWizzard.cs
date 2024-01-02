using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatWizzard
{
    public int VwId { get; set; }

    public string VwKrok { get; set; } = null!;

    public int VwWersja { get; set; }

    public DateTime VwData { get; set; }
}
