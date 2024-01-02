using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlStanCywilny
{
    public int ScId { get; set; }

    public string ScStan { get; set; } = null!;

    public virtual ICollection<PrPracownik> PrPracowniks { get; set; } = new List<PrPracownik>();
}
