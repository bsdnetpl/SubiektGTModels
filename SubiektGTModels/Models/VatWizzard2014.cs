using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatWizzard2014
{
    public int Vw3Id { get; set; }

    public string Vw3Krok { get; set; } = null!;

    public int Vw3Wersja { get; set; }

    public DateTime Vw3Data { get; set; }
}
