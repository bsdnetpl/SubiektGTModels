using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwZdjecieTw
{
    public int ZdId { get; set; }

    public int ZdIdTowar { get; set; }

    public byte[]? ZdZdjecie { get; set; }

    public bool ZdGlowne { get; set; }

    public int? ZdCrc { get; set; }

    public virtual TwTowar ZdIdTowarNavigation { get; set; } = null!;
}
