using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrmPromocjeParametr
{
    public int PrmpId { get; set; }

    public int PrmpParamEwidId { get; set; }

    public virtual ParEwid PrmpParamEwid { get; set; } = null!;
}
