using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdParametrHist
{
    public int ParId { get; set; }

    public string ParNazwa { get; set; } = null!;

    public DateTime? ParWazneOd { get; set; }

    public DateTime? ParWazneDo { get; set; }

    public decimal? ParWartoscCy { get; set; }

    public bool? ParWartoscBool { get; set; }

    public DateTime? ParWartoscDate { get; set; }

    public int? ParWartoscLong { get; set; }

    public string? ParWartoscString { get; set; }

    public bool ParAbonament { get; set; }
}
