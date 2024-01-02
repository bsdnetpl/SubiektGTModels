using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IsRodzajInstytucji
{
    public int IrId { get; set; }

    public string IrNazwa { get; set; } = null!;

    public virtual ICollection<IsInstytucja> IsInstytucjas { get; set; } = new List<IsInstytucja>();
}
