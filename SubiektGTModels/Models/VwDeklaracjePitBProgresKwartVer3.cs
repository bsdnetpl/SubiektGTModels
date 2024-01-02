using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDeklaracjePitBProgresKwartVer3
{
    public int? DeIdObiektu { get; set; }

    public DateTime DeOkresDo { get; set; }

    public int DpNrPola { get; set; }

    public string Nip { get; set; } = null!;

    public string? Regon { get; set; }

    public string? NazwaPelna { get; set; }

    public string? Miejsce { get; set; }

    public string? Udzial { get; set; }

    public string? Przychod { get; set; }

    public string? Koszty { get; set; }
}
