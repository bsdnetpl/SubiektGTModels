using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class XwlEwid
{
    public int WlxIdSource { get; set; }

    public int? WlxLevel { get; set; }

    public int? WlxIdFrom { get; set; }

    public string WlxEntry { get; set; } = null!;

    public int? WlxRank { get; set; }
}
