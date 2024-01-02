using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NetWiadomoscWersja
{
    public int NevId { get; set; }

    public string NevNumer { get; set; } = null!;

    public string NevNazwa { get; set; } = null!;

    public int NevTyp { get; set; }
}
