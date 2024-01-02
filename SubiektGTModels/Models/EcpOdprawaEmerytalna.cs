using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EcpOdprawaEmerytalna
{
    public int EcpoeId { get; set; }

    public int EcpoeIdPrac { get; set; }

    public DateTime EcpoeData { get; set; }

    public int EcpoeSkladnZmienne { get; set; }

    public DateTime EcpoeMiesRozl { get; set; }
}
