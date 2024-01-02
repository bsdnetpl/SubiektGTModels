using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKrajPochodzenium
{
    public int KrpId { get; set; }

    public string KrpKod { get; set; } = null!;

    public string KrpNazwa { get; set; } = null!;

    public virtual ICollection<TwTowar> TwTowars { get; set; } = new List<TwTowar>();
}
