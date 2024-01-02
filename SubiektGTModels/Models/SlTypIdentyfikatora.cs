using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlTypIdentyfikatora
{
    public int TidId { get; set; }

    public string TidKod { get; set; } = null!;

    public string TidNazwa { get; set; } = null!;

    public virtual ICollection<PdWspolnik> PdWspolniks { get; set; } = new List<PdWspolnik>();

    public virtual ICollection<PrPracownik> PrPracowniks { get; set; } = new List<PrPracownik>();
}
