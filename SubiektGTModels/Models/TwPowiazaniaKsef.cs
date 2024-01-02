using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwPowiazaniaKsef
{
    public int PksefId { get; set; }

    public int? PksefTwId { get; set; }

    public int PksefKhId { get; set; }

    public string PksefTwNazwaKsef { get; set; } = null!;

    public int PksefTypPowiazania { get; set; }

    public string? PksefSymbolUdostawcy { get; set; }

    public string? PksefIdJednUdostawcy { get; set; }

    public string? PksefIdJednLokalnie { get; set; }

    public decimal? PksefPrzelicznik { get; set; }

    public virtual KhKontrahent PksefKh { get; set; } = null!;

    public virtual TwTowar? PksefTw { get; set; }
}
