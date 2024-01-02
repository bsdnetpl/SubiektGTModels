using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwKomplet
{
    public int KplId { get; set; }

    public int KplIdKomplet { get; set; }

    public int KplIdSkladnik { get; set; }

    public decimal KplLiczba { get; set; }

    public virtual TwTowar KplIdSkladnikNavigation { get; set; } = null!;
}
