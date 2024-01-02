using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseRozKhInstykt
{
    public int Ident { get; set; }

    public string Nazwa { get; set; } = null!;

    public string Opis { get; set; } = null!;

    public string? Symbol { get; set; }

    public string Ulica { get; set; } = null!;

    public string? Analityka1 { get; set; }

    public string? Analityka2 { get; set; }

    public int Typ { get; set; }

    public string? GaduGadu { get; set; }

    public string? Skype { get; set; }
}
