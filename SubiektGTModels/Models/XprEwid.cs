using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class XprEwid
{
    public int PrxIdSource { get; set; }

    public int? PrxLevel { get; set; }

    public int? PrxIdFrom { get; set; }

    public string PrxEntry { get; set; } = null!;

    public int? PrxRank { get; set; }
}
