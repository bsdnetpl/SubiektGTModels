using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class OdwOdWykSzablon
{
    public int OdwId { get; set; }

    public string OdwNazwa { get; set; } = null!;

    public string OdwOpis { get; set; } = null!;

    public string OdwUwagi { get; set; } = null!;

    public string OdwZapytanieSql { get; set; } = null!;

    public int OdwTypOdWyk { get; set; }
}
