using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TrOpi
{
    public int TroId { get; set; }

    public int? TroTransakcja { get; set; }

    public string? TroOpis { get; set; }

    public string? TroOpisTekst { get; set; }
}
