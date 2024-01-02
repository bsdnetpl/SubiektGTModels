using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwProfileUprawnieniaMag
{
    public int UprId { get; set; }

    public string? UprModul { get; set; }

    public string? UprNazwa { get; set; }

    public bool? UprMagazynowe { get; set; }
}
