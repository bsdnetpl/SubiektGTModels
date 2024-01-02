using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmSearchContent
{
    public int EscId { get; set; }

    public int EscEmailId { get; set; }

    public string EscContent { get; set; } = null!;
}
