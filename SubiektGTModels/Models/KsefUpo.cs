using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KsefUpo
{
    public int KsefuId { get; set; }

    public int KsefuSesjaId { get; set; }

    public DateTime KsefuDataPobrania { get; set; }

    public string KsefuUpo { get; set; } = null!;

    public virtual KsefSesja KsefuSesja { get; set; } = null!;
}
