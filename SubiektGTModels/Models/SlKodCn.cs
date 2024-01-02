using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKodCn
{
    public int KcnId { get; set; }

    public string KcnKodCn { get; set; } = null!;

    public string KcnOpis { get; set; } = null!;

    public int? KcnGtu { get; set; }
}
