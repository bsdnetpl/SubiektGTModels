using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RbRachBankowyWirtualnyWspolnika
{
    public int RbwsId { get; set; }

    public int RbwsIdRachunkuWirtualnego { get; set; }

    public int RbwsIdWspolnika { get; set; }

    public virtual RbRachBankowyWirtualny RbwsIdRachunkuWirtualnegoNavigation { get; set; } = null!;

    public virtual PdWspolnik RbwsIdWspolnikaNavigation { get; set; } = null!;
}
