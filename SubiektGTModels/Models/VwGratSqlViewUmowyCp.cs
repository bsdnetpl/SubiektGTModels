using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratSqlViewUmowyCp
{
    public int Ident { get; set; }

    public string Numer { get; set; } = null!;

    public string? RodzajUmowyCp { get; set; }

    public string? NaCzas { get; set; }

    public DateTime DataOd { get; set; }

    public DateTime? DataDo { get; set; }

    public DateTime? DataRozwiazania { get; set; }

    public string? PrzyczynaRozwiazania { get; set; }

    public string Tytul { get; set; } = null!;

    public string Szczegoly { get; set; } = null!;

    public decimal Kwota { get; set; }

    public string ZusEmerytalne { get; set; } = null!;

    public string ZusRentowe { get; set; } = null!;

    public string ZusChorobowe { get; set; } = null!;

    public string ZusWypadkowe { get; set; } = null!;

    public string ZusZdrowotne { get; set; } = null!;

    public string ZusFp { get; set; } = null!;

    public string ZusFgsp { get; set; } = null!;
}
