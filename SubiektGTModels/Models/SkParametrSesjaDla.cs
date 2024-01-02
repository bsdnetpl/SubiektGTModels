using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SkParametrSesjaDla
{
    public int SkpdId { get; set; }

    public int SkpdIdParametr { get; set; }

    public int SkpdTypObiektu { get; set; }

    public int? SkpdIdObiektu { get; set; }

    public string? SkpdNazwaObiektu { get; set; }
}
