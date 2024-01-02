using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlUprawnienie
{
    public int UprId { get; set; }

    public string UprNazwa { get; set; } = null!;

    public virtual ICollection<PrUprawnienium> PrUprawnienia { get; set; } = new List<PrUprawnienium>();
}
