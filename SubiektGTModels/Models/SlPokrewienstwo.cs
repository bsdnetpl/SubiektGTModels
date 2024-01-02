using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlPokrewienstwo
{
    public int PokrId { get; set; }

    public string PokrKod { get; set; } = null!;

    public string PokrOpis { get; set; } = null!;

    public virtual ICollection<PrPracownik> PrPracowniks { get; set; } = new List<PrPracownik>();
}
