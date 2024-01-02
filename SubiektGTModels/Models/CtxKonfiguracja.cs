using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class CtxKonfiguracja
{
    public string CtxSection { get; set; } = null!;

    public int CtxUser { get; set; }

    public int CtxData { get; set; }
}
