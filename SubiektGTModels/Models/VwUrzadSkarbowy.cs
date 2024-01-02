using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwUrzadSkarbowy
{
    public int SusId { get; set; }

    public string SusKod { get; set; } = null!;

    public string SusOpis { get; set; } = null!;

    public string SusOpisPelny { get; set; } = null!;
}
