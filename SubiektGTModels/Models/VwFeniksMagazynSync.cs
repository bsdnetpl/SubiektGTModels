using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksMagazynSync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public byte StateId { get; set; }

    public int MagId { get; set; }

    public string MagSymbol { get; set; } = null!;

    public string MagNazwa { get; set; } = null!;

    public int MagStatus { get; set; }

    public string? MagOpis { get; set; }

    public string? MagAnalityka { get; set; }

    public bool MagGlowny { get; set; }

    public bool MagPos { get; set; }
}
