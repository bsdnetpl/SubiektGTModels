using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GrKonfiguracjaEx
{
    public string CgeSection { get; set; } = null!;

    public int CgeUser { get; set; }

    public int CgeService { get; set; }

    public string? CgeVersion { get; set; }

    public byte[]? CgeBinListInfo { get; set; }

    public byte[]? CgeBinColumns { get; set; }

    public byte[]? CgeBinTables { get; set; }

    public byte[]? CgeBinVisibility { get; set; }

    public string? CgeSql { get; set; }

    public string? CgeLastUpdateVersion { get; set; }
}
