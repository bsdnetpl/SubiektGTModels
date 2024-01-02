using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlPrawoDoEmerytury
{
    public int PdeId { get; set; }

    public string PdeKod { get; set; } = null!;

    public string PdeOpis { get; set; } = null!;

    public virtual ICollection<PdWspolnik> PdWspolniks { get; set; } = new List<PdWspolnik>();

    public virtual ICollection<PrPracownik> PrPracowniks { get; set; } = new List<PrPracownik>();
}
