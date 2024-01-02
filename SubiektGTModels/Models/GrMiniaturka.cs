using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GrMiniaturka
{
    public int GrmId { get; set; }

    public byte[]? GrmMiniaturka { get; set; }

    public int GrmIdObiektu { get; set; }

    public int GrmTypObiektu { get; set; }
}
