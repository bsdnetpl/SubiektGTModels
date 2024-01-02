using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrOkresyUrlopowBezplatnych
{
    public int OubId { get; set; }

    public int OubIdBo { get; set; }

    public DateTime OubDataOd { get; set; }

    public DateTime OubDataDo { get; set; }

    public virtual PrBo OubIdBoNavigation { get; set; } = null!;
}
