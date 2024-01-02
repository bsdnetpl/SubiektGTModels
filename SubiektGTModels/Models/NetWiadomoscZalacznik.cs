using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NetWiadomoscZalacznik
{
    public int NezId { get; set; }

    public int NezIdWiadomosci { get; set; }

    public string NezNazwa { get; set; } = null!;

    public string NezUrl { get; set; } = null!;
}
