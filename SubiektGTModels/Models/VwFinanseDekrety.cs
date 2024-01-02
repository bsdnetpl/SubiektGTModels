using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseDekrety
{
    public int NzdIdRozrachunku { get; set; }

    public int NzdIdDekretu { get; set; }

    public string DkoKonto { get; set; } = null!;

    public string DkrNrPelny { get; set; } = null!;
}
