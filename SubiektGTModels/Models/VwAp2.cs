using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwAp2
{
    public int Ident { get; set; }

    public bool Zabl { get; set; }

    public string Nazwa { get; set; } = null!;

    public DateTime? DataUruchomienia { get; set; }

    public DateTime? OkresOd { get; set; }

    public DateTime? OkresDo { get; set; }

    public string? Uruchomil { get; set; }
}
