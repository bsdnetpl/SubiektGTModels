using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseRozKhLookup
{
    public int Ident { get; set; }

    public string? Nazwa { get; set; }

    public string? Opis { get; set; }

    public string Symbol { get; set; } = null!;

    public string? Ulica { get; set; }

    public int? Konto { get; set; }

    public int? RokObrotowy { get; set; }

    public string? Analityka1 { get; set; }

    public string? Analityka2 { get; set; }

    public int Typ { get; set; }
}
