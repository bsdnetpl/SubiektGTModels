using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IcenCennikTowar
{
    public int IcentId { get; set; }

    public int IcentCennikId { get; set; }

    public int IcentTwId { get; set; }

    public decimal IcentCenaNetto { get; set; }

    public decimal IcentCenaBrutto { get; set; }

    public virtual IcenCennikiIndywidualne IcentCennik { get; set; } = null!;

    public virtual TwTowar IcentTw { get; set; } = null!;
}
