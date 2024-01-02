using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GrKonfiguracja
{
    public string CgSection { get; set; } = null!;

    public int CgUser { get; set; }

    public string? CgVersion { get; set; }

    public byte[]? CgBinListInfo { get; set; }

    public byte[]? CgBinColumns { get; set; }

    public byte[]? CgBinTables { get; set; }

    public byte[]? CgBinVisibility { get; set; }
}
