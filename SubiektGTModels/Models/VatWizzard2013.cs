using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatWizzard2013
{
    public int Vw2Id { get; set; }

    public string Vw2Krok { get; set; } = null!;

    public int Vw2Wersja { get; set; }

    public DateTime Vw2Data { get; set; }
}
