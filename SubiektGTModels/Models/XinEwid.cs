using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class XinEwid
{
    public int InxIdSource { get; set; }

    public int? InxLevel { get; set; }

    public int? InxIdFrom { get; set; }

    public string InxEntry { get; set; } = null!;

    public int? InxRank { get; set; }
}
