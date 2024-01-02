using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class LenTwTowar
{
    public int TableKey { get; set; }

    public int Dl { get; set; }

    public virtual TwTowar TableKeyNavigation { get; set; } = null!;
}
