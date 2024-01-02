using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwJednMiary
{
    public int JmId { get; set; }

    public int JmIdTowar { get; set; }

    public string JmIdJednMiary { get; set; } = null!;

    public decimal JmPrzelicznik { get; set; }

    public bool JmDlaNaklejek { get; set; }

    public virtual TwTowar JmIdTowarNavigation { get; set; } = null!;
}
