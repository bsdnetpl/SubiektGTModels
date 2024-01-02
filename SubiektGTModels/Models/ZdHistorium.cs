using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZdHistorium
{
    public int ZdhId { get; set; }

    public int ZdhIdZadania { get; set; }

    public int ZdhOperator { get; set; }

    public string ZdhOpis { get; set; } = null!;

    public DateTime ZdhData { get; set; }
}
