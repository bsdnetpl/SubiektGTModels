using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseRozNierozliczone
{
    public int? DniSpoznienia { get; set; }

    public int? NzfIdAdresu { get; set; }

    public int NzfTyp { get; set; }

    public int NzfId { get; set; }

    public DateTime NzfData { get; set; }

    public string? NzfNumerPelny { get; set; }

    public DateTime? NzfTerminPlatnosci { get; set; }

    public string NzfIdWaluty { get; set; } = null!;

    public int? NzfProgram { get; set; }

    public int? NzfZrodlo { get; set; }

    public bool NzfPowiazanie { get; set; }

    public decimal? Naleznosc { get; set; }

    public decimal? Zobowiazanie { get; set; }
}
