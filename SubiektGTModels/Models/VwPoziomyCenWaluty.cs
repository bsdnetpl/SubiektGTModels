using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwPoziomyCenWaluty
{
    public int? Ident { get; set; }

    public string Nazwa { get; set; } = null!;

    public string Waluta { get; set; } = null!;

    public int? Rodzaj { get; set; }
}
