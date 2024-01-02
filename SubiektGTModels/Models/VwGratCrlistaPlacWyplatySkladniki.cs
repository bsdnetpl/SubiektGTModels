using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrlistaPlacWyplatySkladniki
{
    public int IdWyplaty { get; set; }

    public int IdSkladnika { get; set; }

    public decimal? Wartosc { get; set; }
}
