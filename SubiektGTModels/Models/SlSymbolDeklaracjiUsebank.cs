using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlSymbolDeklaracjiUsebank
{
    public int SduId { get; set; }

    public string SduSymbol { get; set; } = null!;

    public string SduZobowiazanie { get; set; } = null!;

    public int SduTypRachBank { get; set; }

    public bool SduSystemowy { get; set; }
}
