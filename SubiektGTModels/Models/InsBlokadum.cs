using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class InsBlokadum
{
    public int Obid { get; set; }

    public int Obextra { get; set; }

    public int Obtype { get; set; }

    public string? Workstation { get; set; }

    public string? Username { get; set; }

    public DateTime? Locktime { get; set; }

    public int Counter { get; set; }
}
