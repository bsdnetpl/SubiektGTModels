using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksSlWalutaSync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public byte StateId { get; set; }

    public string WlSymbol { get; set; } = null!;

    public string WlNazwa { get; set; } = null!;

    public int WlLiczbaJednostek { get; set; }

    public bool WlAktywna { get; set; }
}
