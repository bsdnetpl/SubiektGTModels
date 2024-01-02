using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RbRachBankowyWirtualnyInstytucji
{
    public int RbiId { get; set; }

    public int RbiIdRachunkuWirtualnego { get; set; }

    public int RbiIdInstytucji { get; set; }

    public virtual RbRachBankowyWirtualny RbiIdRachunkuWirtualnegoNavigation { get; set; } = null!;
}
