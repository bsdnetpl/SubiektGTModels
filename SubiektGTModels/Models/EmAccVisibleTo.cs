using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmAccVisibleTo
{
    public int EvId { get; set; }

    public int EvAccountId { get; set; }

    public int EvUserId { get; set; }

    public virtual EmAccount EvAccount { get; set; } = null!;
}
