using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GrGridWlasny
{
    public int GrgId { get; set; }

    public int GrgIdGrida { get; set; }

    public string GrgSql { get; set; } = null!;

    public byte[]? GrgBinListInfo { get; set; }

    public byte[]? GrgBinColumns { get; set; }

    public byte[]? GrgBinTables { get; set; }

    public byte[]? GrgBinVisibility { get; set; }

    public string? GrgSqlWhere { get; set; }

    public bool GrgKolumnyWlasneWidoczne { get; set; }
}
