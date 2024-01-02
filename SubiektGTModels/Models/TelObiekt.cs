using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TelObiekt
{
    public int ToId { get; set; }

    public int ToIdObiektu { get; set; }

    public int ToTypObiektu { get; set; }

    public string ToNazwa { get; set; } = null!;

    public string ToNumer { get; set; } = null!;

    public bool ToPodstawowy { get; set; }
}
