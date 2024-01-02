using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwModul
{
    public int UimId { get; set; }

    public int? UimIdWzorca { get; set; }

    public string UimTytul { get; set; } = null!;

    public string? UimTytulWzorca { get; set; }

    public int UimProgram { get; set; }

    public int UimStatusNowosci { get; set; }

    public string UimOpis { get; set; } = null!;
}
