using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TrHistorium
{
    public int TrhId { get; set; }

    public int TrhTransakcja { get; set; }

    public int TrhOperator { get; set; }

    public string TrhOpis { get; set; } = null!;

    public DateTime TrhData { get; set; }
}
