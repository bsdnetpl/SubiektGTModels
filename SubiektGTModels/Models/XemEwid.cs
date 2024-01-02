using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class XemEwid
{
    public int EmxIdSource { get; set; }

    public int? EmxLevel { get; set; }

    public int? EmxIdFrom { get; set; }

    public string EmxEntry { get; set; } = null!;

    public int? EmxRank { get; set; }
}
