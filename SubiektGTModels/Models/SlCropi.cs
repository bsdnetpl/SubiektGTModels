using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlCropi
{
    public int CroId { get; set; }

    public int CroTyp { get; set; }

    public string CroOpis1 { get; set; } = null!;

    public string CroOpis2 { get; set; } = null!;
}
