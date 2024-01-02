using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RbRachBankowySynchronizacja
{
    public int RbsId { get; set; }

    public int RbsIdRachPersonel { get; set; }

    public DateTime RbsGodzina { get; set; }
}
