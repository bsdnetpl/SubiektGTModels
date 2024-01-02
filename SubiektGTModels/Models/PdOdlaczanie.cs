using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdOdlaczanie
{
    public string PdoKomputer { get; set; } = null!;

    public string PdoProces { get; set; } = null!;

    public DateTime PdoData { get; set; }
}
