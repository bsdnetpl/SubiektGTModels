using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdStatystyka
{
    public int PdsId { get; set; }

    public DateTime? PdsData { get; set; }

    public int? PdsStatus { get; set; }

    public string? PdsRaport { get; set; }
}
