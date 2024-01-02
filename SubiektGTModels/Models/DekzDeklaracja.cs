using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DekzDeklaracja
{
    public int DzdId { get; set; }

    public int DzdIdNaliczenia { get; set; }

    public int DzdRodzaj { get; set; }

    public string DzdTresc { get; set; } = null!;

    public string DzdOpis { get; set; } = null!;

    public virtual DekzNaliczenie DzdIdNaliczeniaNavigation { get; set; } = null!;
}
