using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class InsSzpiegParametr
{
    public int InsspId { get; set; }

    public int InsspParamEwidId { get; set; }

    public virtual ParEwid InsspParamEwid { get; set; } = null!;
}
