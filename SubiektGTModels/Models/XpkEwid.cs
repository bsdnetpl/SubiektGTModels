using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class XpkEwid
{
    public int PkxIdSource { get; set; }

    public int? PkxLevel { get; set; }

    public int? PkxIdFrom { get; set; }

    public string PkxEntry { get; set; } = null!;

    public int? PkxRank { get; set; }
}
