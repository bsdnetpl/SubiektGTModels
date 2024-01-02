using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IdxTwTowar
{
    public int TermId { get; set; }

    public int TableKey { get; set; }

    public int Tf { get; set; }

    public virtual TwTowar TableKeyNavigation { get; set; } = null!;

    public virtual TrmTwTowar Term { get; set; } = null!;
}
