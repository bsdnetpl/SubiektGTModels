using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IcenCennikiParametr
{
    public int IcenpId { get; set; }

    public int IcenpParamEwidId { get; set; }

    public virtual ParEwid IcenpParamEwid { get; set; } = null!;
}
