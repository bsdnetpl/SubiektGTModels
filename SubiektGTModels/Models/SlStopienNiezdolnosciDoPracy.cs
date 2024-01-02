using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlStopienNiezdolnosciDoPracy
{
    public int StnpId { get; set; }

    public string StnpKod { get; set; } = null!;

    public string StnpOpis { get; set; } = null!;

    public virtual ICollection<PdWspolnik> PdWspolniks { get; set; } = new List<PdWspolnik>();

    public virtual ICollection<PrPracownik> PrPracowniks { get; set; } = new List<PrPracownik>();
}
