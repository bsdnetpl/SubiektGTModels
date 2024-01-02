using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlModelTowar
{
    public int MtwId { get; set; }

    public int MtwIdModel { get; set; }

    public int MtwIdTowar { get; set; }

    public virtual SlModelTw MtwIdModelNavigation { get; set; } = null!;

    public virtual TwTowar MtwIdTowarNavigation { get; set; } = null!;
}
