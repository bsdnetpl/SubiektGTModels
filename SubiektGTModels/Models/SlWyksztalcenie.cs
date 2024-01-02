using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlWyksztalcenie
{
    public int WykId { get; set; }

    public string WykKod { get; set; } = null!;

    public string WykOpis { get; set; } = null!;

    public virtual ICollection<PrPracownik> PrPracowniks { get; set; } = new List<PrPracownik>();
}
