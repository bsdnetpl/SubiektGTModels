using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseDekretyWszystkie
{
    public int NzdIdRozrachunku { get; set; }

    public int NzdIdDekretu { get; set; }

    public int NzdIdRoku { get; set; }

    public int NzdStatus { get; set; }

    public string DkoKonto { get; set; } = null!;

    public int Strona { get; set; }

    public string? DkrNrPelny { get; set; }

    public int? DkrId { get; set; }

    public string? DkrRejestr { get; set; }

    public int? DkrNumer { get; set; }
}
