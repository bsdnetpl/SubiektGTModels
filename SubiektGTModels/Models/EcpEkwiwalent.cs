using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EcpEkwiwalent
{
    public int EkwId { get; set; }

    public int EkwIdPrac { get; set; }

    public DateTime EkwData { get; set; }

    public int EkwGodziny { get; set; }

    public int EkwSkladnStale { get; set; }

    public int EkwSkladnZmienne { get; set; }

    public DateTime EkwMiesRozl { get; set; }

    public int EkwWymiar { get; set; }
}
