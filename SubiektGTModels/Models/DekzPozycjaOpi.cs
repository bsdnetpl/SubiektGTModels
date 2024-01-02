using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DekzPozycjaOpi
{
    public int DzoId { get; set; }

    public int DzoRodzajDeklaracji { get; set; }

    public int DzoNrPola { get; set; }

    public string DzoPozycja { get; set; } = null!;

    public string DzoOpis { get; set; } = null!;

    public bool DzoUzywane { get; set; }

    public int DzoFormat { get; set; }

    public int DzoRozmiar { get; set; }

    public string DzoBlok { get; set; } = null!;
}
