using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlTypWplaty
{
    public int WptId { get; set; }

    public string WptSymbol { get; set; } = null!;

    public string WptNazwa { get; set; } = null!;
}
