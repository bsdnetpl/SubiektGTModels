using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlStopienNiepelnosprawnosci
{
    public int StnId { get; set; }

    public string StnKod { get; set; } = null!;

    public string StnOpis { get; set; } = null!;

    public virtual ICollection<PdWspolnik> PdWspolniks { get; set; } = new List<PdWspolnik>();

    public virtual ICollection<PrPracownik> PrPracowniks { get; set; } = new List<PrPracownik>();
}
