using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TrmTwTowar
{
    public int Id { get; set; }

    public string Term { get; set; } = null!;

    public int Df { get; set; }

    public virtual ICollection<IdxTwTowar> IdxTwTowars { get; set; } = new List<IdxTwTowar>();
}
