using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlOddzialNfz
{
    public int OnfzId { get; set; }

    public string OnfzKod { get; set; } = null!;

    public string OnfzOpis { get; set; } = null!;

    public virtual ICollection<PrPracownik> PrPracowniks { get; set; } = new List<PrPracownik>();
}
