using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiIkona
{
    public int UikId { get; set; }

    public int UikTypPolecenia { get; set; }

    public int UikIdPolecenia { get; set; }

    public int? UikIdSerwisu { get; set; }

    public string UikUrl { get; set; } = null!;

    public byte[]? UikIkona { get; set; }
}
