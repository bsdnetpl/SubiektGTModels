using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratSqlViewListaRachunkowUmowy
{
    public int IdUmowy { get; set; }

    public string Numer { get; set; } = null!;

    public DateTime Data { get; set; }

    public decimal BruttoDuze { get; set; }

    public decimal? SkladkiZus { get; set; }

    public decimal ZaliczkaNaPodatek { get; set; }

    public decimal SkladkaZdrowotna { get; set; }

    public decimal Netto { get; set; }

    public decimal KwotaDoWyplaty { get; set; }

    public decimal ObciazeniePracodawcy { get; set; }
}
