using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwWyciagiBankoweLookup
{
    public int Ident { get; set; }

    public int StatusKsiegowy { get; set; }

    public DateTime Data { get; set; }

    public string Numer { get; set; } = null!;

    public DateTime OkresOd { get; set; }

    public DateTime OkresDo { get; set; }

    public decimal SaldoPoczatkowe { get; set; }

    public decimal SaldoKoncowe { get; set; }

    public decimal? Persaldo { get; set; }

    public string? Waluta { get; set; }

    public string? NazwaRachunku { get; set; }

    public string? NumerRachunku { get; set; }

    public string? NazwaBanku { get; set; }

    public int? IdRachunku { get; set; }

    public int? IdKategorii { get; set; }

    public string? Kategoria { get; set; }

    public string? NrWyciaguHb { get; set; }

    public int? IdWyciaguHb { get; set; }
}
