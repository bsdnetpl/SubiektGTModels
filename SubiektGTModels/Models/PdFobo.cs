using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdFobo
{
    public int FbId { get; set; }

    public int? FbBusinessId { get; set; }

    public int FbSharedServices { get; set; }

    public string? FbEmail { get; set; }

    public string? FbFileOutputPath { get; set; }

    public bool? FbMoveToOutput { get; set; }
}
