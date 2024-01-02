using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwProfileMagazynyErp
{
    public int MagId { get; set; }

    public string MagSymbol { get; set; } = null!;

    public string MagNazwa { get; set; } = null!;

    public string? AdrAdres { get; set; }
}
